// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    public partial class DdosSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (DdosCustomPolicy != null)
            {
                writer.WritePropertyName("ddosCustomPolicy"u8);
                writer.WriteObjectValue(DdosCustomPolicy);
            }
            if (ProtectionCoverage.HasValue)
            {
                writer.WritePropertyName("protectionCoverage"u8);
                writer.WriteStringValue(ProtectionCoverage.Value.ToString());
            }
            if (ProtectedIP.HasValue)
            {
                writer.WritePropertyName("protectedIP"u8);
                writer.WriteBooleanValue(ProtectedIP.Value);
            }
            writer.WriteEndObject();
        }

        internal static DdosSettings DeserializeDdosSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SubResource ddosCustomPolicy = default;
            DdosSettingsProtectionCoverage? protectionCoverage = default;
            bool? protectedIP = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ddosCustomPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ddosCustomPolicy = SubResource.DeserializeSubResource(property.Value);
                    continue;
                }
                if (property.NameEquals("protectionCoverage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectionCoverage = new DdosSettingsProtectionCoverage(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protectedIP"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectedIP = property.Value.GetBoolean();
                    continue;
                }
            }
            return new DdosSettings(ddosCustomPolicy, protectionCoverage, protectedIP);
        }
    }
}
