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
    /// Extension methods for AssetsOperations.
    /// </summary>
    public static partial class AssetsOperationsExtensions
    {
            /// <summary>
            /// List Assets
            /// </summary>
            /// <remarks>
            /// List Assets in the Media Services account with optional filtering and
            /// ordering
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
            public static IPage<Asset> List(this IAssetsOperations operations, string resourceGroupName, string accountName, ODataQuery<Asset> odataQuery = default(ODataQuery<Asset>))
            {
                return operations.ListAsync(resourceGroupName, accountName, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List Assets
            /// </summary>
            /// <remarks>
            /// List Assets in the Media Services account with optional filtering and
            /// ordering
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
            public static async Task<IPage<Asset>> ListAsync(this IAssetsOperations operations, string resourceGroupName, string accountName, ODataQuery<Asset> odataQuery = default(ODataQuery<Asset>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, accountName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get an Asset
            /// </summary>
            /// <remarks>
            /// Get the details of an Asset in the Media Services account
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
            /// <param name='assetName'>
            /// The Asset name.
            /// </param>
            public static Asset Get(this IAssetsOperations operations, string resourceGroupName, string accountName, string assetName)
            {
                return operations.GetAsync(resourceGroupName, accountName, assetName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get an Asset
            /// </summary>
            /// <remarks>
            /// Get the details of an Asset in the Media Services account
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
            /// <param name='assetName'>
            /// The Asset name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Asset> GetAsync(this IAssetsOperations operations, string resourceGroupName, string accountName, string assetName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, assetName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update an Asset
            /// </summary>
            /// <remarks>
            /// Creates or updates an Asset in the Media Services account
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
            /// <param name='assetName'>
            /// The Asset name.
            /// </param>
            /// <param name='parameters'>
            /// The request parameters
            /// </param>
            public static Asset CreateOrUpdate(this IAssetsOperations operations, string resourceGroupName, string accountName, string assetName, Asset parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, accountName, assetName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update an Asset
            /// </summary>
            /// <remarks>
            /// Creates or updates an Asset in the Media Services account
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
            /// <param name='assetName'>
            /// The Asset name.
            /// </param>
            /// <param name='parameters'>
            /// The request parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Asset> CreateOrUpdateAsync(this IAssetsOperations operations, string resourceGroupName, string accountName, string assetName, Asset parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, accountName, assetName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete an Asset.
            /// </summary>
            /// <remarks>
            /// Deletes an Asset in the Media Services account
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
            /// <param name='assetName'>
            /// The Asset name.
            /// </param>
            public static void Delete(this IAssetsOperations operations, string resourceGroupName, string accountName, string assetName)
            {
                operations.DeleteAsync(resourceGroupName, accountName, assetName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete an Asset.
            /// </summary>
            /// <remarks>
            /// Deletes an Asset in the Media Services account
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
            /// <param name='assetName'>
            /// The Asset name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IAssetsOperations operations, string resourceGroupName, string accountName, string assetName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, assetName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update an Asset
            /// </summary>
            /// <remarks>
            /// Updates an existing Asset in the Media Services account
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
            /// <param name='assetName'>
            /// The Asset name.
            /// </param>
            /// <param name='parameters'>
            /// The request parameters
            /// </param>
            public static Asset Update(this IAssetsOperations operations, string resourceGroupName, string accountName, string assetName, Asset parameters)
            {
                return operations.UpdateAsync(resourceGroupName, accountName, assetName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update an Asset
            /// </summary>
            /// <remarks>
            /// Updates an existing Asset in the Media Services account
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
            /// <param name='assetName'>
            /// The Asset name.
            /// </param>
            /// <param name='parameters'>
            /// The request parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Asset> UpdateAsync(this IAssetsOperations operations, string resourceGroupName, string accountName, string assetName, Asset parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, accountName, assetName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List the Asset URLs
            /// </summary>
            /// <remarks>
            /// Lists the Asset SAS URLs used for uploading and downloading Asset content
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
            /// <param name='assetName'>
            /// The Asset name.
            /// </param>
            /// <param name='parameters'>
            /// The request parameters
            /// </param>
            public static AssetContainerSas ListContainerSas(this IAssetsOperations operations, string resourceGroupName, string accountName, string assetName, ListContainerSasInput parameters)
            {
                return operations.ListContainerSasAsync(resourceGroupName, accountName, assetName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List the Asset URLs
            /// </summary>
            /// <remarks>
            /// Lists the Asset SAS URLs used for uploading and downloading Asset content
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
            /// <param name='assetName'>
            /// The Asset name.
            /// </param>
            /// <param name='parameters'>
            /// The request parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AssetContainerSas> ListContainerSasAsync(this IAssetsOperations operations, string resourceGroupName, string accountName, string assetName, ListContainerSasInput parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListContainerSasWithHttpMessagesAsync(resourceGroupName, accountName, assetName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the Asset storage key
            /// </summary>
            /// <remarks>
            /// Gets the Asset storage encryption keys used to decrypt content created by
            /// version 2 of the Media Services API
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
            /// <param name='assetName'>
            /// The Asset name.
            /// </param>
            public static AssetStorageEncryptionKey GetEncryptionKey(this IAssetsOperations operations, string resourceGroupName, string accountName, string assetName)
            {
                return operations.GetEncryptionKeyAsync(resourceGroupName, accountName, assetName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the Asset storage key
            /// </summary>
            /// <remarks>
            /// Gets the Asset storage encryption keys used to decrypt content created by
            /// version 2 of the Media Services API
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
            /// <param name='assetName'>
            /// The Asset name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AssetStorageEncryptionKey> GetEncryptionKeyAsync(this IAssetsOperations operations, string resourceGroupName, string accountName, string assetName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetEncryptionKeyWithHttpMessagesAsync(resourceGroupName, accountName, assetName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List Assets
            /// </summary>
            /// <remarks>
            /// List Assets in the Media Services account with optional filtering and
            /// ordering
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Asset> ListNext(this IAssetsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List Assets
            /// </summary>
            /// <remarks>
            /// List Assets in the Media Services account with optional filtering and
            /// ordering
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
            public static async Task<IPage<Asset>> ListNextAsync(this IAssetsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
