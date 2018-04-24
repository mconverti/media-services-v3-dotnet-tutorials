﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Media.Encoding.Rest.ArmClient;
using Microsoft.Media.Encoding.Rest.ArmClient.Models;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Newtonsoft.Json;

namespace UploadEncodeAndStreamFiles
{
    class Program
    {
        private const string AdaptiveStreamingTransformName = "MyTransformWithAdaptiveStreamingPreset";
        private const string PredefinedClearStreamingOnly = "Predefined_ClearStreamingOnly";
        private const string InputMP4FileName = @"ignite.mp4";
        private const string OutputFolder = @"Output";


        static void Main(string[] args)
        {
            ConfigWrapper config = new ConfigWrapper();

            IAzureMediaServicesClient client = CreateMediaServicesClient(config);
                      
            Transform transform = EnsureTransformExists(client, config.ResourceGroup, config.AccountName, AdaptiveStreamingTransformName);

            string jobName = "job-" + Guid.NewGuid().ToString();
            string locatorName = "locator-" + Guid.NewGuid().ToString();
            string outputAssetName = "output" + Guid.NewGuid().ToString();
            string inputAssetName = "input-" + Guid.NewGuid().ToString();

            CreateInputAsset(client, config.ResourceGroup, config.AccountName, inputAssetName, InputMP4FileName);

            JobInput jobInput = new JobInputAsset(assetName: inputAssetName);

            Asset outputAsset = client.Assets.CreateOrUpdate(config.ResourceGroup, config.AccountName, outputAssetName, new Asset());

            Job job = SubmitJob(client, config.ResourceGroup, config.AccountName, AdaptiveStreamingTransformName, jobName, jobInput, outputAssetName);

            job = WaitForJobToFinish(client, config.ResourceGroup, config.AccountName, AdaptiveStreamingTransformName, jobName);

            if (job.State == JobState.Finished)
            {
                Console.WriteLine("Job finished.");
                if (!Directory.Exists(OutputFolder))
                    Directory.CreateDirectory(OutputFolder);
                DownloadResults(client, config.ResourceGroup, config.AccountName, outputAssetName, OutputFolder);

                StreamingLocator locator = CreateStreamingLocator(client, config.ResourceGroup, config.AccountName, outputAsset.Name, locatorName);

                IList<string> urls = GetStreamingURLs(client, config.ResourceGroup, config.AccountName, locator.Name);
                foreach (var url in urls)
                {
                    Console.WriteLine(url);
                }
            }
        }

        private static IAzureMediaServicesClient CreateMediaServicesClient(ConfigWrapper config)
        {
            ArmClientCredentials credentials = new ArmClientCredentials(config);

            return new AzureMediaServicesClient(config.ArmEndpoint, credentials)
            {
                SubscriptionId = config.SubscriptionId,
            };
        }

        private static Asset CreateInputAsset(IAzureMediaServicesClient client, string resourceGroupName, string accountName, string assetName, string fileToUpload)
        {
            Asset asset = client.Assets.CreateOrUpdate(resourceGroupName, accountName, assetName, new Asset());

            var response = client.Assets.ListContainerSas(resourceGroupName, accountName, assetName, new ListContainerSasInput()
            {
                Permissions = AssetContainerPermission.ReadWrite,
                ExpiryTime = DateTimeOffset.Now.AddHours(4)
            });

            var sasUri = new Uri(response.AssetContainerSasUrls.First());
            CloudBlobContainer container = new CloudBlobContainer(sasUri);
            var blob = container.GetBlockBlobReference(Path.GetFileName(fileToUpload));
            blob.UploadFromFile(fileToUpload);

            return asset;
        }

        private static Transform EnsureTransformExists(IAzureMediaServicesClient client,
            string resourceGroupName,
            string accountName,
            string transformName)
        {
            Transform transform = client.Transforms.Get(resourceGroupName, accountName, transformName);

            if (transform == null)
            {
                var output = new[]
                {
                    new TransformOutput
                    {
                        Preset = new BuiltInStandardEncoderPreset()
                        {
                            // TODO: change H264MultipleBitrate720p to AdaptiveStreaming
                            PresetName = EncoderNamedPreset.H264MultipleBitrate720p
                        }
                    }
                };

                transform = new Transform(output);
                transform = client.Transforms.CreateOrUpdate(resourceGroupName, accountName, transformName, transform);
            }

            return transform;
        }

        private static Job SubmitJob(IAzureMediaServicesClient client, string resourceGroupName, string accountName, string transformName, string jobName, JobInput jobInput, string outputAssetName)
        {
            JobOutput[] jobOutputs =
            {
                new JobOutputAsset(outputAssetName),
            };

            Job job = client.Jobs.Create(
                resourceGroupName,
                accountName,
                transformName,
                jobName,
                new Job
                {
                    Input = jobInput,
                    Outputs = jobOutputs,
                });

            return job;
        }

        private static Job WaitForJobToFinish(IAzureMediaServicesClient client,
            string resourceGroupName,
            string accountName,
            string transformName,
            string jobName)
        {
            int SleepInterval = 60 * 1000;

            Job job = null;

            while (true)
            {
                job = client.Jobs.Get(resourceGroupName, accountName, transformName, jobName);

                if (job.State == JobState.Finished || job.State == JobState.Error || job.State == JobState.Canceled)
                {
                    break;
                }

                Console.WriteLine($"Job is {job.State}.");
                for (int i = 0; i < job.Outputs.Count; i++)
                {
                    JobOutput output = job.Outputs[i];
                    Console.Write($"\tJobOutput[{i}] is {output.State}.");
                    if (output.State == JobState.Processing)
                    {
                        Console.Write($"  Progress: {output.Progress}");
                    }
                    Console.WriteLine();
                }
                System.Threading.Thread.Sleep(SleepInterval);
            }

            return job;
        }


        private static StreamingLocator CreateStreamingLocator(IAzureMediaServicesClient client,
                                                                string resourceGroup,
                                                                string accountName,
                                                                string assetName,
                                                                string locatorName)
        {
            StreamingLocator locator =
                client.StreamingLocators.Create(resourceGroup,
                accountName,
                locatorName,
                new StreamingLocator()
                {
                    AssetName = assetName,
                    StreamingPolicyName = PredefinedClearStreamingOnly,
                });

            return locator;
        }

        static IList<string> GetStreamingURLs(
            IAzureMediaServicesClient client,
            string resourceGroupName,
            string accountName,
            String locatorName)
        {
            IList<string> streamingURLs = new List<string>();

            string streamingUrlPrefx = "";

            StreamingEndpoint streamingEndpoint = client.StreamingEndpoints.Get(resourceGroupName, accountName, "default");

            if (streamingEndpoint != null)
            {
                streamingUrlPrefx = streamingEndpoint.HostName;

                if (streamingEndpoint.ResourceState != StreamingEndpointResourceState.Running)
                    client.StreamingEndpoints.Start(resourceGroupName, accountName, "default");
            }

            foreach (var path in client.StreamingLocators.ListPaths(resourceGroupName, accountName, locatorName).StreamingPaths)
            {
                streamingURLs.Add("http://" + streamingUrlPrefx + path.Paths[0].ToString());
            }

            return streamingURLs;
        }

        private static void DownloadResults(IAzureMediaServicesClient client,
          string resourceGroup,
          string accountName,
          string assetName,
          string resultsFolder)
        {
            ListContainerSasInput parameters = new ListContainerSasInput(permissions: AssetContainerPermission.Read, expiryTime: DateTimeOffset.UtcNow.AddHours(1));
            AssetContainerSas assetContainerSas = client.Assets.ListContainerSas(resourceGroup, accountName, assetName, parameters);

            Uri containerSasUrl = new Uri(assetContainerSas.AssetContainerSasUrls.FirstOrDefault());
            CloudBlobContainer container = new CloudBlobContainer(containerSasUrl);

            string directory = Path.Combine(resultsFolder, assetName);
            Directory.CreateDirectory(directory);

            Console.WriteLine("Downloading results to {0}.", directory);

            foreach (IListBlobItem blobItem in container.ListBlobs(null, true, BlobListingDetails.None))
            {
                if (blobItem is CloudBlockBlob)
                {
                    CloudBlockBlob blob = blobItem as CloudBlockBlob;
                    string filename = Path.Combine(directory, blob.Name);

                    blob.DownloadToFile(filename, FileMode.Create);
                }
            }

            Console.WriteLine("Download complete.");
        }

        static void CleanUp(IAzureMediaServicesClient client,
                string resourceGroupName,
                string accountName,
                string transformName)
        {
            foreach (var job in client.Jobs.List(resourceGroupName, accountName, transformName))
            {
                client.Jobs.Delete(resourceGroupName, accountName, transformName, job.Name);
            }

            foreach (var asset in client.Assets.List(resourceGroupName, accountName))
            {
                client.Assets.Delete(resourceGroupName, accountName, asset.Name);
            }
        }


    }
}
