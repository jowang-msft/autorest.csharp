// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace MgmtMockAndSample
{
    public partial class VirtualMachineExtensionImageData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (OperatingSystem != null)
            {
                writer.WritePropertyName("operatingSystem"u8);
                writer.WriteStringValue(OperatingSystem);
            }
            if (ComputeRole != null)
            {
                writer.WritePropertyName("computeRole"u8);
                writer.WriteStringValue(ComputeRole);
            }
            if (HandlerSchema != null)
            {
                writer.WritePropertyName("handlerSchema"u8);
                writer.WriteStringValue(HandlerSchema);
            }
            if (VmScaleSetEnabled.HasValue)
            {
                writer.WritePropertyName("vmScaleSetEnabled"u8);
                writer.WriteBooleanValue(VmScaleSetEnabled.Value);
            }
            if (SupportsMultipleExtensions.HasValue)
            {
                writer.WritePropertyName("supportsMultipleExtensions"u8);
                writer.WriteBooleanValue(SupportsMultipleExtensions.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VirtualMachineExtensionImageData DeserializeVirtualMachineExtensionImageData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureLocation? location = default;
            IReadOnlyDictionary<string, string> tags = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string operatingSystem = default;
            string computeRole = default;
            string handlerSchema = default;
            bool? vmScaleSetEnabled = default;
            bool? supportsMultipleExtensions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("operatingSystem"u8))
                        {
                            operatingSystem = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("computeRole"u8))
                        {
                            computeRole = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("handlerSchema"u8))
                        {
                            handlerSchema = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vmScaleSetEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vmScaleSetEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("supportsMultipleExtensions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            supportsMultipleExtensions = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VirtualMachineExtensionImageData(
                id,
                name,
                type,
                systemData,
                operatingSystem,
                computeRole,
                handlerSchema,
                vmScaleSetEnabled,
                supportsMultipleExtensions,
                location,
                tags ?? new ChangeTrackingDictionary<string, string>());
        }
    }
}
