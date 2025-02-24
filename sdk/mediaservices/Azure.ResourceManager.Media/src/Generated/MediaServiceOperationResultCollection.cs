// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Media
{
    /// <summary>
    /// A class representing a collection of <see cref="MediaServiceOperationResultResource" /> and their operations.
    /// Each <see cref="MediaServiceOperationResultResource" /> in the collection will belong to the same instance of <see cref="SubscriptionResource" />.
    /// To get a <see cref="MediaServiceOperationResultCollection" /> instance call the GetMediaServiceOperationResults method from an instance of <see cref="SubscriptionResource" />.
    /// </summary>
    public partial class MediaServiceOperationResultCollection : ArmCollection
    {
        private readonly ClientDiagnostics _mediaServiceOperationResultMediaServicesOperationResultsClientDiagnostics;
        private readonly MediaServicesOperationResultsRestOperations _mediaServiceOperationResultMediaServicesOperationResultsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MediaServiceOperationResultCollection"/> class for mocking. </summary>
        protected MediaServiceOperationResultCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MediaServiceOperationResultCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MediaServiceOperationResultCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mediaServiceOperationResultMediaServicesOperationResultsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Media", MediaServiceOperationResultResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MediaServiceOperationResultResource.ResourceType, out string mediaServiceOperationResultMediaServicesOperationResultsApiVersion);
            _mediaServiceOperationResultMediaServicesOperationResultsRestClient = new MediaServicesOperationResultsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mediaServiceOperationResultMediaServicesOperationResultsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get media service operation result.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Media/locations/{locationName}/mediaServicesOperationResults/{operationId}
        /// Operation Id: MediaServicesOperationResults_Get
        /// </summary>
        /// <param name="locationName"> Location name. </param>
        /// <param name="operationId"> Operation Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public virtual async Task<Response<MediaServiceOperationResultResource>> GetAsync(AzureLocation locationName, string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            using var scope = _mediaServiceOperationResultMediaServicesOperationResultsClientDiagnostics.CreateScope("MediaServiceOperationResultCollection.Get");
            scope.Start();
            try
            {
                var response = await _mediaServiceOperationResultMediaServicesOperationResultsRestClient.GetAsync(Id.SubscriptionId, locationName, operationId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MediaServiceOperationResultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get media service operation result.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Media/locations/{locationName}/mediaServicesOperationResults/{operationId}
        /// Operation Id: MediaServicesOperationResults_Get
        /// </summary>
        /// <param name="locationName"> Location name. </param>
        /// <param name="operationId"> Operation Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public virtual Response<MediaServiceOperationResultResource> Get(AzureLocation locationName, string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            using var scope = _mediaServiceOperationResultMediaServicesOperationResultsClientDiagnostics.CreateScope("MediaServiceOperationResultCollection.Get");
            scope.Start();
            try
            {
                var response = _mediaServiceOperationResultMediaServicesOperationResultsRestClient.Get(Id.SubscriptionId, locationName, operationId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MediaServiceOperationResultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Media/locations/{locationName}/mediaServicesOperationResults/{operationId}
        /// Operation Id: MediaServicesOperationResults_Get
        /// </summary>
        /// <param name="locationName"> Location name. </param>
        /// <param name="operationId"> Operation Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(AzureLocation locationName, string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            using var scope = _mediaServiceOperationResultMediaServicesOperationResultsClientDiagnostics.CreateScope("MediaServiceOperationResultCollection.Exists");
            scope.Start();
            try
            {
                var response = await _mediaServiceOperationResultMediaServicesOperationResultsRestClient.GetAsync(Id.SubscriptionId, locationName, operationId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Media/locations/{locationName}/mediaServicesOperationResults/{operationId}
        /// Operation Id: MediaServicesOperationResults_Get
        /// </summary>
        /// <param name="locationName"> Location name. </param>
        /// <param name="operationId"> Operation Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public virtual Response<bool> Exists(AzureLocation locationName, string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            using var scope = _mediaServiceOperationResultMediaServicesOperationResultsClientDiagnostics.CreateScope("MediaServiceOperationResultCollection.Exists");
            scope.Start();
            try
            {
                var response = _mediaServiceOperationResultMediaServicesOperationResultsRestClient.Get(Id.SubscriptionId, locationName, operationId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
