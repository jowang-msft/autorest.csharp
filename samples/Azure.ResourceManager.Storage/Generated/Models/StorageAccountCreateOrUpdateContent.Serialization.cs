// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class StorageAccountCreateOrUpdateContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sku"u8);
            writer.WriteObjectValue(Sku);
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (ExtendedLocation != null)
            {
                writer.WritePropertyName("extendedLocation"u8);
                JsonSerializer.Serialize(writer, ExtendedLocation);
            }
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Identity != null)
            {
                writer.WritePropertyName("identity"u8);
                var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                JsonSerializer.Serialize(writer, Identity, serializeOptions);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (PublicNetworkAccess.HasValue)
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (SasPolicy != null)
            {
                writer.WritePropertyName("sasPolicy"u8);
                writer.WriteObjectValue(SasPolicy);
            }
            if (KeyPolicy != null)
            {
                writer.WritePropertyName("keyPolicy"u8);
                writer.WriteObjectValue(KeyPolicy);
            }
            if (CustomDomain != null)
            {
                writer.WritePropertyName("customDomain"u8);
                writer.WriteObjectValue(CustomDomain);
            }
            if (Encryption != null)
            {
                writer.WritePropertyName("encryption"u8);
                writer.WriteObjectValue(Encryption);
            }
            if (NetworkRuleSet != null)
            {
                writer.WritePropertyName("networkAcls"u8);
                writer.WriteObjectValue(NetworkRuleSet);
            }
            if (AccessTier.HasValue)
            {
                writer.WritePropertyName("accessTier"u8);
                writer.WriteStringValue(AccessTier.Value.ToSerialString());
            }
            if (AzureFilesIdentityBasedAuthentication != null)
            {
                writer.WritePropertyName("azureFilesIdentityBasedAuthentication"u8);
                writer.WriteObjectValue(AzureFilesIdentityBasedAuthentication);
            }
            if (EnableHttpsTrafficOnly.HasValue)
            {
                writer.WritePropertyName("supportsHttpsTrafficOnly"u8);
                writer.WriteBooleanValue(EnableHttpsTrafficOnly.Value);
            }
            if (IsHnsEnabled.HasValue)
            {
                writer.WritePropertyName("isHnsEnabled"u8);
                writer.WriteBooleanValue(IsHnsEnabled.Value);
            }
            if (LargeFileSharesState.HasValue)
            {
                writer.WritePropertyName("largeFileSharesState"u8);
                writer.WriteStringValue(LargeFileSharesState.Value.ToString());
            }
            if (RoutingPreference != null)
            {
                writer.WritePropertyName("routingPreference"u8);
                writer.WriteObjectValue(RoutingPreference);
            }
            if (AllowBlobPublicAccess.HasValue)
            {
                writer.WritePropertyName("allowBlobPublicAccess"u8);
                writer.WriteBooleanValue(AllowBlobPublicAccess.Value);
            }
            if (MinimumTlsVersion.HasValue)
            {
                writer.WritePropertyName("minimumTlsVersion"u8);
                writer.WriteStringValue(MinimumTlsVersion.Value.ToString());
            }
            if (AllowSharedKeyAccess.HasValue)
            {
                writer.WritePropertyName("allowSharedKeyAccess"u8);
                writer.WriteBooleanValue(AllowSharedKeyAccess.Value);
            }
            if (EnableNfsV3.HasValue)
            {
                writer.WritePropertyName("isNfsV3Enabled"u8);
                writer.WriteBooleanValue(EnableNfsV3.Value);
            }
            if (AllowCrossTenantReplication.HasValue)
            {
                writer.WritePropertyName("allowCrossTenantReplication"u8);
                writer.WriteBooleanValue(AllowCrossTenantReplication.Value);
            }
            if (DefaultToOAuthAuthentication.HasValue)
            {
                writer.WritePropertyName("defaultToOAuthAuthentication"u8);
                writer.WriteBooleanValue(DefaultToOAuthAuthentication.Value);
            }
            if (ImmutableStorageWithVersioning != null)
            {
                writer.WritePropertyName("immutableStorageWithVersioning"u8);
                writer.WriteObjectValue(ImmutableStorageWithVersioning);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
