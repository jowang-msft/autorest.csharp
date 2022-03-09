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
using Azure.ResourceManager.Core;
using MgmtExpandResourceTypes.Models;

namespace MgmtExpandResourceTypes
{
    /// <summary> A Class representing a RecordSetSoa along with the instance operations that can be performed on it. </summary>
    public partial class RecordSetSoa : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="RecordSetSoa"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string zoneName, string relativeRecordSetName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}/SOA/{relativeRecordSetName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _recordSetSoaRecordSetsClientDiagnostics;
        private readonly RecordSetsRestOperations _recordSetSoaRecordSetsRestClient;
        private readonly RecordSetData _data;

        /// <summary> Initializes a new instance of the <see cref="RecordSetSoa"/> class for mocking. </summary>
        protected RecordSetSoa()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "RecordSetSoa"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal RecordSetSoa(ArmClient client, RecordSetData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="RecordSetSoa"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal RecordSetSoa(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _recordSetSoaRecordSetsClientDiagnostics = new ClientDiagnostics("MgmtExpandResourceTypes", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string recordSetSoaRecordSetsApiVersion);
            _recordSetSoaRecordSetsRestClient = new RecordSetsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, recordSetSoaRecordSetsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/dnsZones/SOA";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual RecordSetData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a record set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}/SOA/{relativeRecordSetName}
        /// Operation Id: RecordSets_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RecordSetSoa>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _recordSetSoaRecordSetsClientDiagnostics.CreateScope("RecordSetSoa.Get");
            scope.Start();
            try
            {
                var response = await _recordSetSoaRecordSetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, "SOA".ToRecordType(), Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RecordSetSoa(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a record set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}/SOA/{relativeRecordSetName}
        /// Operation Id: RecordSets_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RecordSetSoa> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _recordSetSoaRecordSetsClientDiagnostics.CreateScope("RecordSetSoa.Get");
            scope.Start();
            try
            {
                var response = _recordSetSoaRecordSetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, "SOA".ToRecordType(), Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RecordSetSoa(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a record set from a DNS zone. This operation cannot be undone.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}/SOA/{relativeRecordSetName}
        /// Operation Id: RecordSets_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="ifMatch"> The etag of the record set. Omit this value to always delete the current record set. Specify the last-seen etag value to prevent accidentally deleting any concurrent changes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(bool waitForCompletion, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _recordSetSoaRecordSetsClientDiagnostics.CreateScope("RecordSetSoa.Delete");
            scope.Start();
            try
            {
                var response = await _recordSetSoaRecordSetsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, "SOA".ToRecordType(), Id.Name, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtExpandResourceTypesArmOperation(response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a record set from a DNS zone. This operation cannot be undone.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}/SOA/{relativeRecordSetName}
        /// Operation Id: RecordSets_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="ifMatch"> The etag of the record set. Omit this value to always delete the current record set. Specify the last-seen etag value to prevent accidentally deleting any concurrent changes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(bool waitForCompletion, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _recordSetSoaRecordSetsClientDiagnostics.CreateScope("RecordSetSoa.Delete");
            scope.Start();
            try
            {
                var response = _recordSetSoaRecordSetsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, "SOA".ToRecordType(), Id.Name, ifMatch, cancellationToken);
                var operation = new MgmtExpandResourceTypesArmOperation(response);
                if (waitForCompletion)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates a record set within a DNS zone.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}/SOA/{relativeRecordSetName}
        /// Operation Id: RecordSets_Update
        /// </summary>
        /// <param name="parameters"> Parameters supplied to the Update operation. </param>
        /// <param name="ifMatch"> The etag of the record set. Omit this value to always overwrite the current record set. Specify the last-seen etag value to prevent accidentally overwriting concurrent changes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual async Task<Response<RecordSetSoa>> UpdateAsync(RecordSetData parameters, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _recordSetSoaRecordSetsClientDiagnostics.CreateScope("RecordSetSoa.Update");
            scope.Start();
            try
            {
                var response = await _recordSetSoaRecordSetsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, "SOA".ToRecordType(), Id.Name, parameters, ifMatch, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new RecordSetSoa(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates a record set within a DNS zone.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}/SOA/{relativeRecordSetName}
        /// Operation Id: RecordSets_Update
        /// </summary>
        /// <param name="parameters"> Parameters supplied to the Update operation. </param>
        /// <param name="ifMatch"> The etag of the record set. Omit this value to always overwrite the current record set. Specify the last-seen etag value to prevent accidentally overwriting concurrent changes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual Response<RecordSetSoa> Update(RecordSetData parameters, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _recordSetSoaRecordSetsClientDiagnostics.CreateScope("RecordSetSoa.Update");
            scope.Start();
            try
            {
                var response = _recordSetSoaRecordSetsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, "SOA".ToRecordType(), Id.Name, parameters, ifMatch, cancellationToken);
                return Response.FromValue(new RecordSetSoa(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
