// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.Sample.Models;

namespace Azure.ResourceManager.Sample
{
    public partial class DedicatedHostData : IUtf8JsonSerializable, IJsonModel<DedicatedHostData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DedicatedHostData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DedicatedHostData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DedicatedHostData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DedicatedHostData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("sku"u8);
            writer.WriteObjectValue(Sku);
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
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (PlatformFaultDomain.HasValue)
            {
                writer.WritePropertyName("platformFaultDomain"u8);
                writer.WriteNumberValue(PlatformFaultDomain.Value);
            }
            if (AutoReplaceOnFailure.HasValue)
            {
                writer.WritePropertyName("autoReplaceOnFailure"u8);
                writer.WriteBooleanValue(AutoReplaceOnFailure.Value);
            }
            if (options.Format != "W" && HostId != null)
            {
                writer.WritePropertyName("hostId"u8);
                writer.WriteStringValue(HostId);
            }
            if (options.Format != "W" && !(VirtualMachines is ChangeTrackingList<Resources.Models.SubResource> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("virtualMachines"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualMachines)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (LicenseType.HasValue)
            {
                writer.WritePropertyName("licenseType"u8);
                writer.WriteStringValue(LicenseType.Value.ToSerialString());
            }
            if (options.Format != "W" && ProvisioningOn.HasValue)
            {
                writer.WritePropertyName("provisioningTime"u8);
                writer.WriteStringValue(ProvisioningOn.Value, "O");
            }
            if (options.Format != "W" && ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (options.Format != "W" && InstanceView != null)
            {
                writer.WritePropertyName("instanceView"u8);
                writer.WriteObjectValue(InstanceView);
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        DedicatedHostData IJsonModel<DedicatedHostData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DedicatedHostData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DedicatedHostData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDedicatedHostData(document.RootElement, options);
        }

        internal static DedicatedHostData DeserializeDedicatedHostData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SampleSku sku = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<int> platformFaultDomain = default;
            Optional<bool> autoReplaceOnFailure = default;
            Optional<string> hostId = default;
            IReadOnlyList<Resources.Models.SubResource> virtualMachines = default;
            Optional<DedicatedHostLicenseType> licenseType = default;
            Optional<DateTimeOffset> provisioningTime = default;
            Optional<string> provisioningState = default;
            Optional<DedicatedHostInstanceView> instanceView = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    sku = SampleSku.DeserializeSampleSku(property.Value, options);
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
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("platformFaultDomain"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            platformFaultDomain = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("autoReplaceOnFailure"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoReplaceOnFailure = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("hostId"u8))
                        {
                            hostId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("virtualMachines"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<Resources.Models.SubResource> array = new List<Resources.Models.SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<Resources.Models.SubResource>(item.GetRawText()));
                            }
                            virtualMachines = array;
                            continue;
                        }
                        if (property0.NameEquals("licenseType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            licenseType = property0.Value.GetString().ToDedicatedHostLicenseType();
                            continue;
                        }
                        if (property0.NameEquals("provisioningTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("instanceView"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            instanceView = DedicatedHostInstanceView.DeserializeDedicatedHostInstanceView(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DedicatedHostData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, sku, Optional.ToNullable(platformFaultDomain), Optional.ToNullable(autoReplaceOnFailure), hostId.Value, virtualMachines ?? new ChangeTrackingList<Resources.Models.SubResource>(), Optional.ToNullable(licenseType), Optional.ToNullable(provisioningTime), provisioningState.Value, instanceView.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Name != null)
            {
                builder.Append("  name:");
                if (Name.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{Name}'''");
                }
                else
                {
                    builder.AppendLine($" '{Name}'");
                }
            }

            builder.Append("  location:");
            builder.AppendLine($" '{Location.ToString()}'");

            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                if (Tags.Any())
                {
                    builder.Append("  tags:");
                    builder.AppendLine(" {");
                    foreach (var item in Tags)
                    {
                        builder.Append($"    {item.Key}:");
                        if (item.Value == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        if (item.Value.Contains(Environment.NewLine))
                        {
                            builder.AppendLine(" '''");
                            builder.AppendLine($"{item.Value}'''");
                        }
                        else
                        {
                            builder.AppendLine($" '{item.Value}'");
                        }
                    }
                    builder.AppendLine("  }");
                }
            }

            if (Sku != null)
            {
                builder.Append("  sku:");
                AppendChildObject(builder, Sku, options, 2, false);
            }

            if (Id != null)
            {
                builder.Append("  id:");
                builder.AppendLine($" '{Id.ToString()}'");
            }

            if (SystemData != null)
            {
                builder.Append("  systemData:");
                builder.AppendLine($" '{SystemData.ToString()}'");
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            if (PlatformFaultDomain.HasValue)
            {
                builder.Append("    platformFaultDomain:");
                builder.AppendLine($" {PlatformFaultDomain.Value}");
            }

            if (AutoReplaceOnFailure.HasValue)
            {
                builder.Append("    autoReplaceOnFailure:");
                var boolValue = AutoReplaceOnFailure.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (HostId != null)
            {
                builder.Append("    hostId:");
                if (HostId.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{HostId}'''");
                }
                else
                {
                    builder.AppendLine($" '{HostId}'");
                }
            }

            if (!(VirtualMachines is ChangeTrackingList<Resources.Models.SubResource> collection0 && collection0.IsUndefined))
            {
                if (VirtualMachines.Any())
                {
                    builder.Append("    virtualMachines:");
                    builder.AppendLine(" [");
                    foreach (var item in VirtualMachines)
                    {
                        AppendChildObject(builder, item, options, 6, true);
                    }
                    builder.AppendLine("    ]");
                }
            }

            if (LicenseType.HasValue)
            {
                builder.Append("    licenseType:");
                builder.AppendLine($" '{LicenseType.Value.ToSerialString()}'");
            }

            if (ProvisioningOn.HasValue)
            {
                builder.Append("    provisioningTime:");
                var formattedDateTimeString = TypeFormatters.ToString(ProvisioningOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (ProvisioningState != null)
            {
                builder.Append("    provisioningState:");
                if (ProvisioningState.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{ProvisioningState}'''");
                }
                else
                {
                    builder.AppendLine($" '{ProvisioningState}'");
                }
            }

            if (InstanceView != null)
            {
                builder.Append("    instanceView:");
                AppendChildObject(builder, InstanceView, options, 4, false);
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            bool inMultilineString = false;
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (inMultilineString)
                {
                    if (line.Contains("'''"))
                    {
                        inMultilineString = false;
                    }
                    stringBuilder.AppendLine(line);
                    continue;
                }
                if (line.Contains("'''"))
                {
                    inMultilineString = true;
                    stringBuilder.AppendLine($"{indent}{line}");
                    continue;
                }
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<DedicatedHostData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DedicatedHostData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(DedicatedHostData)} does not support '{options.Format}' format.");
            }
        }

        DedicatedHostData IPersistableModel<DedicatedHostData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DedicatedHostData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDedicatedHostData(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(DedicatedHostData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DedicatedHostData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
