// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace _Azure.ResourceManager.Models.Resources
{
    /// <summary>
    /// A class representing a collection of <see cref="TopLevelTrackedResource"/> and their operations.
    /// Each <see cref="TopLevelTrackedResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="TopLevelTrackedResourceCollection"/> instance call the GetTopLevelTrackedResources method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class TopLevelTrackedResourceCollection : ArmCollection, IEnumerable<TopLevelTrackedResource>, IAsyncEnumerable<TopLevelTrackedResource>
    {
        private readonly ClientDiagnostics _topLevelTrackedResourceClientDiagnostics;
        private readonly TopLevelTrackedResourcesRestOperations _topLevelTrackedResourceRestClient;

        /// <summary> Initializes a new instance of the <see cref="TopLevelTrackedResourceCollection"/> class for mocking. </summary>
        protected TopLevelTrackedResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TopLevelTrackedResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal TopLevelTrackedResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _topLevelTrackedResourceClientDiagnostics = new ClientDiagnostics("_Azure.ResourceManager.Models.Resources", TopLevelTrackedResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(TopLevelTrackedResource.ResourceType, out string topLevelTrackedResourceApiVersion);
            _topLevelTrackedResourceRestClient = new TopLevelTrackedResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, topLevelTrackedResourceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a TopLevelTrackedResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Azure.ResourceManager.Models.Resources/topLevelTrackedResources/{topLevelTrackedResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopLevelTrackedResources_CreateOrReplace</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TopLevelTrackedResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="topLevelTrackedResourceName"> arm resource name for path. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topLevelTrackedResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topLevelTrackedResourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<TopLevelTrackedResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string topLevelTrackedResourceName, TopLevelTrackedResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topLevelTrackedResourceName, nameof(topLevelTrackedResourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _topLevelTrackedResourceClientDiagnostics.CreateScope("TopLevelTrackedResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _topLevelTrackedResourceRestClient.CreateOrReplaceAsync(Id.SubscriptionId, Id.ResourceGroupName, topLevelTrackedResourceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ResourcesArmOperation<TopLevelTrackedResource>(new TopLevelTrackedResourceOperationSource(Client), _topLevelTrackedResourceClientDiagnostics, Pipeline, _topLevelTrackedResourceRestClient.CreateCreateOrReplaceRequest(Id.SubscriptionId, Id.ResourceGroupName, topLevelTrackedResourceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a TopLevelTrackedResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Azure.ResourceManager.Models.Resources/topLevelTrackedResources/{topLevelTrackedResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopLevelTrackedResources_CreateOrReplace</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TopLevelTrackedResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="topLevelTrackedResourceName"> arm resource name for path. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topLevelTrackedResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topLevelTrackedResourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<TopLevelTrackedResource> CreateOrUpdate(WaitUntil waitUntil, string topLevelTrackedResourceName, TopLevelTrackedResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topLevelTrackedResourceName, nameof(topLevelTrackedResourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _topLevelTrackedResourceClientDiagnostics.CreateScope("TopLevelTrackedResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _topLevelTrackedResourceRestClient.CreateOrReplace(Id.SubscriptionId, Id.ResourceGroupName, topLevelTrackedResourceName, data, cancellationToken);
                var operation = new ResourcesArmOperation<TopLevelTrackedResource>(new TopLevelTrackedResourceOperationSource(Client), _topLevelTrackedResourceClientDiagnostics, Pipeline, _topLevelTrackedResourceRestClient.CreateCreateOrReplaceRequest(Id.SubscriptionId, Id.ResourceGroupName, topLevelTrackedResourceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a TopLevelTrackedResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Azure.ResourceManager.Models.Resources/topLevelTrackedResources/{topLevelTrackedResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopLevelTrackedResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TopLevelTrackedResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="topLevelTrackedResourceName"> arm resource name for path. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topLevelTrackedResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topLevelTrackedResourceName"/> is null. </exception>
        public virtual async Task<Response<TopLevelTrackedResource>> GetAsync(string topLevelTrackedResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topLevelTrackedResourceName, nameof(topLevelTrackedResourceName));

            using var scope = _topLevelTrackedResourceClientDiagnostics.CreateScope("TopLevelTrackedResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _topLevelTrackedResourceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, topLevelTrackedResourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TopLevelTrackedResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a TopLevelTrackedResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Azure.ResourceManager.Models.Resources/topLevelTrackedResources/{topLevelTrackedResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopLevelTrackedResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TopLevelTrackedResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="topLevelTrackedResourceName"> arm resource name for path. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topLevelTrackedResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topLevelTrackedResourceName"/> is null. </exception>
        public virtual Response<TopLevelTrackedResource> Get(string topLevelTrackedResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topLevelTrackedResourceName, nameof(topLevelTrackedResourceName));

            using var scope = _topLevelTrackedResourceClientDiagnostics.CreateScope("TopLevelTrackedResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _topLevelTrackedResourceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, topLevelTrackedResourceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TopLevelTrackedResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List TopLevelTrackedResource resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Azure.ResourceManager.Models.Resources/topLevelTrackedResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopLevelTrackedResource_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TopLevelTrackedResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="TopLevelTrackedResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<TopLevelTrackedResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _topLevelTrackedResourceRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _topLevelTrackedResourceRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new TopLevelTrackedResource(Client, TopLevelTrackedResourceData.DeserializeTopLevelTrackedResourceData(e)), _topLevelTrackedResourceClientDiagnostics, Pipeline, "TopLevelTrackedResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List TopLevelTrackedResource resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Azure.ResourceManager.Models.Resources/topLevelTrackedResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopLevelTrackedResource_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TopLevelTrackedResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="TopLevelTrackedResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<TopLevelTrackedResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _topLevelTrackedResourceRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _topLevelTrackedResourceRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new TopLevelTrackedResource(Client, TopLevelTrackedResourceData.DeserializeTopLevelTrackedResourceData(e)), _topLevelTrackedResourceClientDiagnostics, Pipeline, "TopLevelTrackedResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Azure.ResourceManager.Models.Resources/topLevelTrackedResources/{topLevelTrackedResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopLevelTrackedResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TopLevelTrackedResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="topLevelTrackedResourceName"> arm resource name for path. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topLevelTrackedResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topLevelTrackedResourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string topLevelTrackedResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topLevelTrackedResourceName, nameof(topLevelTrackedResourceName));

            using var scope = _topLevelTrackedResourceClientDiagnostics.CreateScope("TopLevelTrackedResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _topLevelTrackedResourceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, topLevelTrackedResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Azure.ResourceManager.Models.Resources/topLevelTrackedResources/{topLevelTrackedResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopLevelTrackedResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TopLevelTrackedResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="topLevelTrackedResourceName"> arm resource name for path. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topLevelTrackedResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topLevelTrackedResourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string topLevelTrackedResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topLevelTrackedResourceName, nameof(topLevelTrackedResourceName));

            using var scope = _topLevelTrackedResourceClientDiagnostics.CreateScope("TopLevelTrackedResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _topLevelTrackedResourceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, topLevelTrackedResourceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Azure.ResourceManager.Models.Resources/topLevelTrackedResources/{topLevelTrackedResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopLevelTrackedResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TopLevelTrackedResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="topLevelTrackedResourceName"> arm resource name for path. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topLevelTrackedResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topLevelTrackedResourceName"/> is null. </exception>
        public virtual async Task<NullableResponse<TopLevelTrackedResource>> GetIfExistsAsync(string topLevelTrackedResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topLevelTrackedResourceName, nameof(topLevelTrackedResourceName));

            using var scope = _topLevelTrackedResourceClientDiagnostics.CreateScope("TopLevelTrackedResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _topLevelTrackedResourceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, topLevelTrackedResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<TopLevelTrackedResource>(response.GetRawResponse());
                return Response.FromValue(new TopLevelTrackedResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Azure.ResourceManager.Models.Resources/topLevelTrackedResources/{topLevelTrackedResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopLevelTrackedResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TopLevelTrackedResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="topLevelTrackedResourceName"> arm resource name for path. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topLevelTrackedResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topLevelTrackedResourceName"/> is null. </exception>
        public virtual NullableResponse<TopLevelTrackedResource> GetIfExists(string topLevelTrackedResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topLevelTrackedResourceName, nameof(topLevelTrackedResourceName));

            using var scope = _topLevelTrackedResourceClientDiagnostics.CreateScope("TopLevelTrackedResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _topLevelTrackedResourceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, topLevelTrackedResourceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<TopLevelTrackedResource>(response.GetRawResponse());
                return Response.FromValue(new TopLevelTrackedResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<TopLevelTrackedResource> IEnumerable<TopLevelTrackedResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<TopLevelTrackedResource> IAsyncEnumerable<TopLevelTrackedResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}