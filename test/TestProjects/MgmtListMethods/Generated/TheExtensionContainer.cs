// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;
using MgmtListMethods.Models;

namespace MgmtListMethods
{
    /// <summary> A class representing collection of TheExtension and their operations over a ResourceGroup. </summary>
    public partial class TheExtensionContainer : ResourceContainer
    {
        /// <summary> Initializes a new instance of the <see cref="TheExtensionContainer"/> class for mocking. </summary>
        protected TheExtensionContainer()
        {
        }

        /// <summary> Initializes a new instance of TheExtensionContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal TheExtensionContainer(ResourceOperations parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private OneResourcesRestOperations _restClient => new OneResourcesRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <summary> Retrieves information about an fake. </summary>
        /// <param name="resourceName"> The name of the fake. </param>
        /// <param name="body"> The body parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> or <paramref name="body"/> is null. </exception>
        public virtual Response<TheExtension> CreateOrUpdate(string resourceName, TheExtensionData body, CancellationToken cancellationToken = default)
        {
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var scope = _clientDiagnostics.CreateScope("TheExtensionContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(resourceName, body, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves information about an fake. </summary>
        /// <param name="resourceName"> The name of the fake. </param>
        /// <param name="body"> The body parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> or <paramref name="body"/> is null. </exception>
        public async virtual Task<Response<TheExtension>> CreateOrUpdateAsync(string resourceName, TheExtensionData body, CancellationToken cancellationToken = default)
        {
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var scope = _clientDiagnostics.CreateScope("TheExtensionContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(resourceName, body, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves information about an fake. </summary>
        /// <param name="resourceName"> The name of the fake. </param>
        /// <param name="body"> The body parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> or <paramref name="body"/> is null. </exception>
        public virtual OneResourcesCreateOrUpdateOperation StartCreateOrUpdate(string resourceName, TheExtensionData body, CancellationToken cancellationToken = default)
        {
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var scope = _clientDiagnostics.CreateScope("TheExtensionContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, resourceName, body, cancellationToken);
                return new OneResourcesCreateOrUpdateOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves information about an fake. </summary>
        /// <param name="resourceName"> The name of the fake. </param>
        /// <param name="body"> The body parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> or <paramref name="body"/> is null. </exception>
        public async virtual Task<OneResourcesCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceName, TheExtensionData body, CancellationToken cancellationToken = default)
        {
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var scope = _clientDiagnostics.CreateScope("TheExtensionContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, resourceName, body, cancellationToken).ConfigureAwait(false);
                return new OneResourcesCreateOrUpdateOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="resourceName"> The name of the fake. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<TheExtension> Get(string resourceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TheExtensionContainer.Get");
            scope.Start();
            try
            {
                if (resourceName == null)
                {
                    throw new ArgumentNullException(nameof(resourceName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, resourceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TheExtension(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="resourceName"> The name of the fake. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<TheExtension>> GetAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TheExtensionContainer.Get");
            scope.Start();
            try
            {
                if (resourceName == null)
                {
                    throw new ArgumentNullException(nameof(resourceName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new TheExtension(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="resourceName"> The name of the fake. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<TheExtension> GetIfExists(string resourceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TheExtensionContainer.GetIfExists");
            scope.Start();
            try
            {
                if (resourceName == null)
                {
                    throw new ArgumentNullException(nameof(resourceName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, resourceName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<TheExtension>(null, response.GetRawResponse())
                    : Response.FromValue(new TheExtension(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="resourceName"> The name of the fake. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<TheExtension>> GetIfExistsAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TheExtensionContainer.GetIfExists");
            scope.Start();
            try
            {
                if (resourceName == null)
                {
                    throw new ArgumentNullException(nameof(resourceName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<TheExtension>(null, response.GetRawResponse())
                    : Response.FromValue(new TheExtension(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="resourceName"> The name of the fake. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string resourceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TheExtensionContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (resourceName == null)
                {
                    throw new ArgumentNullException(nameof(resourceName));
                }

                var response = GetIfExists(resourceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="resourceName"> The name of the fake. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TheExtensionContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (resourceName == null)
                {
                    throw new ArgumentNullException(nameof(resourceName));
                }

                var response = await GetIfExistsAsync(resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves information about an fake. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="TheExtension" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<TheExtension> GetAll(CancellationToken cancellationToken = default)
        {
            Page<TheExtension> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("TheExtensionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAll(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new TheExtension(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<TheExtension> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("TheExtensionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllNextPage(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new TheExtension(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Retrieves information about an fake. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="TheExtension" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<TheExtension> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<TheExtension>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("TheExtensionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new TheExtension(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<TheExtension>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("TheExtensionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllNextPageAsync(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new TheExtension(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="TheExtension" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> GetAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TheExtensionContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(TheExtensionOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="TheExtension" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> GetAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TheExtensionContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(TheExtensionOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, TheExtension, TheExtensionData> Construct() { }
    }
}