// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace MgmtSubscriptionNameParameter
{
    /// <summary> A class representing collection of SBSubscription and their operations over its parent. </summary>
    public partial class SBSubscriptionCollection : ArmCollection, IEnumerable<SBSubscription>, IAsyncEnumerable<SBSubscription>
    {
        private readonly ClientDiagnostics _sbSubscriptionSubscriptionsClientDiagnostics;
        private readonly SubscriptionsRestOperations _sbSubscriptionSubscriptionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SBSubscriptionCollection"/> class for mocking. </summary>
        protected SBSubscriptionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SBSubscriptionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SBSubscriptionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sbSubscriptionSubscriptionsClientDiagnostics = new ClientDiagnostics("MgmtSubscriptionNameParameter", SBSubscription.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(SBSubscription.ResourceType, out string sbSubscriptionSubscriptionsApiVersion);
            _sbSubscriptionSubscriptionsRestClient = new SubscriptionsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, sbSubscriptionSubscriptionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a topic subscription.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions/{subscriptionName}
        /// Operation Id: Subscriptions_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="parameters"> Parameters supplied to create a subscription resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<SBSubscription>> CreateOrUpdateAsync(bool waitForCompletion, string subscriptionName, SBSubscriptionData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionName, nameof(subscriptionName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _sbSubscriptionSubscriptionsClientDiagnostics.CreateScope("SBSubscriptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sbSubscriptionSubscriptionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, subscriptionName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtSubscriptionNameParameterArmOperation<SBSubscription>(Response.FromValue(new SBSubscription(Client, response), response.GetRawResponse()));
                if (waitForCompletion)
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
        /// Creates a topic subscription.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions/{subscriptionName}
        /// Operation Id: Subscriptions_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="parameters"> Parameters supplied to create a subscription resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<SBSubscription> CreateOrUpdate(bool waitForCompletion, string subscriptionName, SBSubscriptionData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionName, nameof(subscriptionName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _sbSubscriptionSubscriptionsClientDiagnostics.CreateScope("SBSubscriptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sbSubscriptionSubscriptionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, subscriptionName, parameters, cancellationToken);
                var operation = new MgmtSubscriptionNameParameterArmOperation<SBSubscription>(Response.FromValue(new SBSubscription(Client, response), response.GetRawResponse()));
                if (waitForCompletion)
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
        /// Returns a subscription description for the specified topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions/{subscriptionName}
        /// Operation Id: Subscriptions_Get
        /// </summary>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionName"/> is null. </exception>
        public virtual async Task<Response<SBSubscription>> GetAsync(string subscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionName, nameof(subscriptionName));

            using var scope = _sbSubscriptionSubscriptionsClientDiagnostics.CreateScope("SBSubscriptionCollection.Get");
            scope.Start();
            try
            {
                var response = await _sbSubscriptionSubscriptionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, subscriptionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SBSubscription(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a subscription description for the specified topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions/{subscriptionName}
        /// Operation Id: Subscriptions_Get
        /// </summary>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionName"/> is null. </exception>
        public virtual Response<SBSubscription> Get(string subscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionName, nameof(subscriptionName));

            using var scope = _sbSubscriptionSubscriptionsClientDiagnostics.CreateScope("SBSubscriptionCollection.Get");
            scope.Start();
            try
            {
                var response = _sbSubscriptionSubscriptionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, subscriptionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SBSubscription(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the subscriptions under a specified topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions
        /// Operation Id: Subscriptions_ListByTopic
        /// </summary>
        /// <param name="skip"> Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="top"> May be used to limit the number of results to the most recent N usageDetails. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SBSubscription" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SBSubscription> GetAllAsync(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<SBSubscription>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sbSubscriptionSubscriptionsClientDiagnostics.CreateScope("SBSubscriptionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sbSubscriptionSubscriptionsRestClient.ListByTopicAsync(Id.SubscriptionId, Id.ResourceGroupName, skip, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SBSubscription(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SBSubscription>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sbSubscriptionSubscriptionsClientDiagnostics.CreateScope("SBSubscriptionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sbSubscriptionSubscriptionsRestClient.ListByTopicNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, skip, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SBSubscription(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// List all the subscriptions under a specified topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions
        /// Operation Id: Subscriptions_ListByTopic
        /// </summary>
        /// <param name="skip"> Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="top"> May be used to limit the number of results to the most recent N usageDetails. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SBSubscription" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SBSubscription> GetAll(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Page<SBSubscription> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sbSubscriptionSubscriptionsClientDiagnostics.CreateScope("SBSubscriptionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sbSubscriptionSubscriptionsRestClient.ListByTopic(Id.SubscriptionId, Id.ResourceGroupName, skip, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SBSubscription(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SBSubscription> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sbSubscriptionSubscriptionsClientDiagnostics.CreateScope("SBSubscriptionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sbSubscriptionSubscriptionsRestClient.ListByTopicNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, skip, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SBSubscription(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions/{subscriptionName}
        /// Operation Id: Subscriptions_Get
        /// </summary>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string subscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionName, nameof(subscriptionName));

            using var scope = _sbSubscriptionSubscriptionsClientDiagnostics.CreateScope("SBSubscriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(subscriptionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions/{subscriptionName}
        /// Operation Id: Subscriptions_Get
        /// </summary>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionName"/> is null. </exception>
        public virtual Response<bool> Exists(string subscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionName, nameof(subscriptionName));

            using var scope = _sbSubscriptionSubscriptionsClientDiagnostics.CreateScope("SBSubscriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(subscriptionName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions/{subscriptionName}
        /// Operation Id: Subscriptions_Get
        /// </summary>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionName"/> is null. </exception>
        public virtual async Task<Response<SBSubscription>> GetIfExistsAsync(string subscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionName, nameof(subscriptionName));

            using var scope = _sbSubscriptionSubscriptionsClientDiagnostics.CreateScope("SBSubscriptionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sbSubscriptionSubscriptionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, subscriptionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SBSubscription>(null, response.GetRawResponse());
                return Response.FromValue(new SBSubscription(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions/{subscriptionName}
        /// Operation Id: Subscriptions_Get
        /// </summary>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionName"/> is null. </exception>
        public virtual Response<SBSubscription> GetIfExists(string subscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionName, nameof(subscriptionName));

            using var scope = _sbSubscriptionSubscriptionsClientDiagnostics.CreateScope("SBSubscriptionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sbSubscriptionSubscriptionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, subscriptionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SBSubscription>(null, response.GetRawResponse());
                return Response.FromValue(new SBSubscription(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SBSubscription> IEnumerable<SBSubscription>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SBSubscription> IAsyncEnumerable<SBSubscription>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
