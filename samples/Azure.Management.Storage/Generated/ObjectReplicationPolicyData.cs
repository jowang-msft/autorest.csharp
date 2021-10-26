// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Management.Storage.Models;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;

namespace Azure.Management.Storage
{
    /// <summary> A class representing the ObjectReplicationPolicy data model. </summary>
    public partial class ObjectReplicationPolicyData : Resource
    {
        /// <summary> Initializes a new instance of ObjectReplicationPolicyData. </summary>
        public ObjectReplicationPolicyData()
        {
            Rules = new ChangeTrackingList<ObjectReplicationPolicyRule>();
        }

        /// <summary> Initializes a new instance of ObjectReplicationPolicyData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="policyId"> A unique id for object replication policy. </param>
        /// <param name="enabledTime"> Indicates when the policy is enabled on the source account. </param>
        /// <param name="sourceAccount"> Required. Source account name. It should be full resource id if allowCrossTenantReplication set to false. </param>
        /// <param name="destinationAccount"> Required. Destination account name. It should be full resource id if allowCrossTenantReplication set to false. </param>
        /// <param name="rules"> The storage account object replication rules. </param>
        internal ObjectReplicationPolicyData(ResourceIdentifier id, string name, ResourceType type, string policyId, DateTimeOffset? enabledTime, string sourceAccount, string destinationAccount, IList<ObjectReplicationPolicyRule> rules) : base(id, name, type)
        {
            PolicyId = policyId;
            EnabledTime = enabledTime;
            SourceAccount = sourceAccount;
            DestinationAccount = destinationAccount;
            Rules = rules;
        }

        /// <summary> A unique id for object replication policy. </summary>
        public string PolicyId { get; }
        /// <summary> Indicates when the policy is enabled on the source account. </summary>
        public DateTimeOffset? EnabledTime { get; }
        /// <summary> Required. Source account name. It should be full resource id if allowCrossTenantReplication set to false. </summary>
        public string SourceAccount { get; set; }
        /// <summary> Required. Destination account name. It should be full resource id if allowCrossTenantReplication set to false. </summary>
        public string DestinationAccount { get; set; }
        /// <summary> The storage account object replication rules. </summary>
        public IList<ObjectReplicationPolicyRule> Rules { get; }
    }
}
