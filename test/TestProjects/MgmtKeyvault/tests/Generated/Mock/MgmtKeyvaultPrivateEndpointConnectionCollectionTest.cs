// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure;
using Azure.Core.TestFramework;
using Azure.ResourceManager.TestFramework;
using MgmtKeyvault;
using MgmtKeyvault.Models;

namespace MgmtKeyvault.Tests.Mock
{
    /// <summary> Test for MgmtKeyvaultPrivateEndpointConnection. </summary>
    public partial class MgmtKeyvaultPrivateEndpointConnectionCollectionMockTests : MockTestBase
    {
        public MgmtKeyvaultPrivateEndpointConnectionCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: KeyVaultPutPrivateEndpointConnection
            string privateEndpointConnectionName = "sample-pec";
            MgmtKeyvault.MgmtKeyvaultPrivateEndpointConnectionData data = new MgmtKeyvault.MgmtKeyvaultPrivateEndpointConnectionData()
            {
                Etag = "",
                PrivateLinkServiceConnectionState = new MgmtKeyvault.Models.MgmtKeyvaultPrivateLinkServiceConnectionState()
                {
                    Status = new MgmtKeyvault.Models.MgmtKeyvaultPrivateEndpointServiceConnectionStatus("Approved"),
                    Description = "My name is Joe and I'm approving this.",
                },
            };

            var vaultResourceId = MgmtKeyvault.VaultResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sample-group", "sample-vault");
            var collection = GetArmClient().GetVaultResource(vaultResourceId).GetMgmtKeyvaultPrivateEndpointConnections();
            await collection.CreateOrUpdateAsync(WaitUntil.Completed, privateEndpointConnectionName, data);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: KeyVaultGetPrivateEndpointConnection
            string privateEndpointConnectionName = "sample-pec";

            var vaultResourceId = MgmtKeyvault.VaultResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sample-group", "sample-vault");
            var collection = GetArmClient().GetVaultResource(vaultResourceId).GetMgmtKeyvaultPrivateEndpointConnections();
            await collection.GetAsync(privateEndpointConnectionName);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: KeyVaultListPrivateEndpointConnection

            var vaultResourceId = MgmtKeyvault.VaultResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sample-group", "sample-vault");
            var collection = GetArmClient().GetVaultResource(vaultResourceId).GetMgmtKeyvaultPrivateEndpointConnections();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}