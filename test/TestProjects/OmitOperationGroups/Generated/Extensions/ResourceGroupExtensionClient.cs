// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using OmitOperationGroups.Models;

namespace OmitOperationGroups
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    internal partial class ResourceGroupExtensionClient : ArmResource
    {
        private ClientDiagnostics _model5sClientDiagnostics;
        private Model5SRestOperations _model5sRestClient;

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupExtensionClient"/> class for mocking. </summary>
        protected ResourceGroupExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics Model5sClientDiagnostics => _model5sClientDiagnostics ??= new ClientDiagnostics("OmitOperationGroups", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
        private Model5SRestOperations Model5sRestClient => _model5sRestClient ??= new Model5SRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of Model2s in the Model2. </summary>
        /// <returns> An object representing collection of Model2s and their operations over a Model2. </returns>
        public virtual Model2Collection GetModel2s()
        {
            return new Model2Collection(Client, Id);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/model5s
        /// Operation Id: Model5s_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Model5" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Model5> GetModel5sAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Model5>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = Model5sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetModel5s");
                scope.Start();
                try
                {
                    var response = await Model5sRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/model5s
        /// Operation Id: Model5s_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Model5" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Model5> GetModel5s(CancellationToken cancellationToken = default)
        {
            Page<Model5> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = Model5sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetModel5s");
                scope.Start();
                try
                {
                    var response = Model5sRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/model5s/{model5sName}
        /// Operation Id: Model5s_CreateOrUpdate
        /// </summary>
        /// <param name="model5SName"> The String to use. </param>
        /// <param name="parameters"> The Model5 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Model5>> CreateOrUpdateModel5Async(string model5SName, Model5 parameters, CancellationToken cancellationToken = default)
        {
            using var scope = Model5sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.CreateOrUpdateModel5");
            scope.Start();
            try
            {
                var response = await Model5sRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, model5SName, parameters, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/model5s/{model5sName}
        /// Operation Id: Model5s_CreateOrUpdate
        /// </summary>
        /// <param name="model5SName"> The String to use. </param>
        /// <param name="parameters"> The Model5 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Model5> CreateOrUpdateModel5(string model5SName, Model5 parameters, CancellationToken cancellationToken = default)
        {
            using var scope = Model5sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.CreateOrUpdateModel5");
            scope.Start();
            try
            {
                var response = Model5sRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, model5SName, parameters, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/model5s/{model5sName}
        /// Operation Id: Model5s_Get
        /// </summary>
        /// <param name="model5SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Model5>> GetModel5Async(string model5SName, CancellationToken cancellationToken = default)
        {
            using var scope = Model5sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetModel5");
            scope.Start();
            try
            {
                var response = await Model5sRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, model5SName, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/model5s/{model5sName}
        /// Operation Id: Model5s_Get
        /// </summary>
        /// <param name="model5SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Model5> GetModel5(string model5SName, CancellationToken cancellationToken = default)
        {
            using var scope = Model5sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetModel5");
            scope.Start();
            try
            {
                var response = Model5sRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, model5SName, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
