// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// </auto-generated>

namespace Microsoft.Media.Encoding.Rest.ArmClient
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for StreamingPoliciesOperations.
    /// </summary>
    public static partial class StreamingPoliciesOperationsExtensions
    {
            /// <summary>
            /// List Streaming Policies
            /// </summary>
            /// <remarks>
            /// Lists the Streaming Policies in the account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='accountName'>
            /// The Media Services account name.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<StreamingPolicy> List(this IStreamingPoliciesOperations operations, string resourceGroupName, string accountName, ODataQuery<StreamingPolicy> odataQuery = default(ODataQuery<StreamingPolicy>))
            {
                return operations.ListAsync(resourceGroupName, accountName, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List Streaming Policies
            /// </summary>
            /// <remarks>
            /// Lists the Streaming Policies in the account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='accountName'>
            /// The Media Services account name.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<StreamingPolicy>> ListAsync(this IStreamingPoliciesOperations operations, string resourceGroupName, string accountName, ODataQuery<StreamingPolicy> odataQuery = default(ODataQuery<StreamingPolicy>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, accountName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a Streaming Policy
            /// </summary>
            /// <remarks>
            /// Get the details of a Streaming Policy in the Media Services account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='accountName'>
            /// The Media Services account name.
            /// </param>
            /// <param name='streamingPolicyName'>
            /// The Streaming Policy name.
            /// </param>
            public static StreamingPolicy Get(this IStreamingPoliciesOperations operations, string resourceGroupName, string accountName, string streamingPolicyName)
            {
                return operations.GetAsync(resourceGroupName, accountName, streamingPolicyName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a Streaming Policy
            /// </summary>
            /// <remarks>
            /// Get the details of a Streaming Policy in the Media Services account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='accountName'>
            /// The Media Services account name.
            /// </param>
            /// <param name='streamingPolicyName'>
            /// The Streaming Policy name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StreamingPolicy> GetAsync(this IStreamingPoliciesOperations operations, string resourceGroupName, string accountName, string streamingPolicyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, streamingPolicyName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a Streaming Policy
            /// </summary>
            /// <remarks>
            /// Create a Streaming Policy in the Media Services account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='accountName'>
            /// The Media Services account name.
            /// </param>
            /// <param name='streamingPolicyName'>
            /// The Streaming Policy name.
            /// </param>
            /// <param name='parameters'>
            /// The request parameters
            /// </param>
            public static StreamingPolicy Create(this IStreamingPoliciesOperations operations, string resourceGroupName, string accountName, string streamingPolicyName, StreamingPolicy parameters)
            {
                return operations.CreateAsync(resourceGroupName, accountName, streamingPolicyName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a Streaming Policy
            /// </summary>
            /// <remarks>
            /// Create a Streaming Policy in the Media Services account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='accountName'>
            /// The Media Services account name.
            /// </param>
            /// <param name='streamingPolicyName'>
            /// The Streaming Policy name.
            /// </param>
            /// <param name='parameters'>
            /// The request parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StreamingPolicy> CreateAsync(this IStreamingPoliciesOperations operations, string resourceGroupName, string accountName, string streamingPolicyName, StreamingPolicy parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, accountName, streamingPolicyName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a Streaming Policy
            /// </summary>
            /// <remarks>
            /// Deletes a Streaming Policy in the Media Services account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='accountName'>
            /// The Media Services account name.
            /// </param>
            /// <param name='streamingPolicyName'>
            /// The Streaming Policy name.
            /// </param>
            public static void Delete(this IStreamingPoliciesOperations operations, string resourceGroupName, string accountName, string streamingPolicyName)
            {
                operations.DeleteAsync(resourceGroupName, accountName, streamingPolicyName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a Streaming Policy
            /// </summary>
            /// <remarks>
            /// Deletes a Streaming Policy in the Media Services account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the Azure subscription.
            /// </param>
            /// <param name='accountName'>
            /// The Media Services account name.
            /// </param>
            /// <param name='streamingPolicyName'>
            /// The Streaming Policy name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IStreamingPoliciesOperations operations, string resourceGroupName, string accountName, string streamingPolicyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, streamingPolicyName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List Streaming Policies
            /// </summary>
            /// <remarks>
            /// Lists the Streaming Policies in the account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<StreamingPolicy> ListNext(this IStreamingPoliciesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List Streaming Policies
            /// </summary>
            /// <remarks>
            /// Lists the Streaming Policies in the account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<StreamingPolicy>> ListNextAsync(this IStreamingPoliciesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
