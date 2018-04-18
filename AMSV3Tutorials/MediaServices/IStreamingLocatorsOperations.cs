// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// </auto-generated>

namespace Microsoft.Media.Encoding.Rest.ArmClient
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// StreamingLocatorsOperations operations.
    /// </summary>
    public partial interface IStreamingLocatorsOperations
    {
        /// <summary>
        /// List Streaming Locators
        /// </summary>
        /// <remarks>
        /// Lists the Streaming Locators in the account
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<StreamingLocator>>> ListWithHttpMessagesAsync(string resourceGroupName, string accountName, ODataQuery<StreamingLocator> odataQuery = default(ODataQuery<StreamingLocator>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a Streaming Locator
        /// </summary>
        /// <remarks>
        /// Get the details of a Streaming Locator in the Media Services
        /// account
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='streamingLocatorName'>
        /// The Streaming Locator name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<StreamingLocator>> GetWithHttpMessagesAsync(string resourceGroupName, string accountName, string streamingLocatorName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create a Streaming Locator
        /// </summary>
        /// <remarks>
        /// Create a Streaming Locator in the Media Services account
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='streamingLocatorName'>
        /// The Streaming Locator name.
        /// </param>
        /// <param name='parameters'>
        /// The request parameters
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<StreamingLocator>> CreateWithHttpMessagesAsync(string resourceGroupName, string accountName, string streamingLocatorName, StreamingLocator parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete a Streaming Locator
        /// </summary>
        /// <remarks>
        /// Deletes a Streaming Locator in the Media Services account
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='streamingLocatorName'>
        /// The Streaming Locator name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string accountName, string streamingLocatorName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List Content Keys
        /// </summary>
        /// <remarks>
        /// List Content Keys used by this Streaming Locator
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='streamingLocatorName'>
        /// The Streaming Locator name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ListContentKeysResponse>> ListContentKeysWithHttpMessagesAsync(string resourceGroupName, string accountName, string streamingLocatorName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List Paths
        /// </summary>
        /// <remarks>
        /// List Paths supported by this Streaming Locator
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='streamingLocatorName'>
        /// The Streaming Locator name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ListPathsResponse>> ListPathsWithHttpMessagesAsync(string resourceGroupName, string accountName, string streamingLocatorName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List Streaming Locators
        /// </summary>
        /// <remarks>
        /// Lists the Streaming Locators in the account
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<StreamingLocator>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
