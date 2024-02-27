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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Sample.Models
{
    public partial class VirtualMachineScaleSetIPConfiguration : IUtf8JsonSerializable, IJsonModel<VirtualMachineScaleSetIPConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineScaleSetIPConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualMachineScaleSetIPConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetIPConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetIPConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Subnet != null)
            {
                writer.WritePropertyName("subnet"u8);
                JsonSerializer.Serialize(writer, Subnet);
            }
            if (Primary.HasValue)
            {
                writer.WritePropertyName("primary"u8);
                writer.WriteBooleanValue(Primary.Value);
            }
            if (PublicIPAddressConfiguration != null)
            {
                writer.WritePropertyName("publicIPAddressConfiguration"u8);
                writer.WriteObjectValue(PublicIPAddressConfiguration);
            }
            if (PrivateIPAddressVersion.HasValue)
            {
                writer.WritePropertyName("privateIPAddressVersion"u8);
                writer.WriteStringValue(PrivateIPAddressVersion.Value.ToString());
            }
            if (!(ApplicationGatewayBackendAddressPools is ChangeTrackingList<WritableSubResource> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("applicationGatewayBackendAddressPools"u8);
                writer.WriteStartArray();
                foreach (var item in ApplicationGatewayBackendAddressPools)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (!(ApplicationSecurityGroups is ChangeTrackingList<WritableSubResource> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("applicationSecurityGroups"u8);
                writer.WriteStartArray();
                foreach (var item in ApplicationSecurityGroups)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (!(LoadBalancerBackendAddressPools is ChangeTrackingList<WritableSubResource> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("loadBalancerBackendAddressPools"u8);
                writer.WriteStartArray();
                foreach (var item in LoadBalancerBackendAddressPools)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (!(LoadBalancerInboundNatPools is ChangeTrackingList<WritableSubResource> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("loadBalancerInboundNatPools"u8);
                writer.WriteStartArray();
                foreach (var item in LoadBalancerInboundNatPools)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
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

        VirtualMachineScaleSetIPConfiguration IJsonModel<VirtualMachineScaleSetIPConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetIPConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetIPConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineScaleSetIPConfiguration(document.RootElement, options);
        }

        internal static VirtualMachineScaleSetIPConfiguration DeserializeVirtualMachineScaleSetIPConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string id = default;
            WritableSubResource subnet = default;
            bool? primary = default;
            VirtualMachineScaleSetPublicIPAddressConfiguration publicIPAddressConfiguration = default;
            IPVersion? privateIPAddressVersion = default;
            IList<WritableSubResource> applicationGatewayBackendAddressPools = default;
            IList<WritableSubResource> applicationSecurityGroups = default;
            IList<WritableSubResource> loadBalancerBackendAddressPools = default;
            IList<WritableSubResource> loadBalancerInboundNatPools = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
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
                        if (property0.NameEquals("subnet"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subnet = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("primary"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            primary = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("publicIPAddressConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicIPAddressConfiguration = VirtualMachineScaleSetPublicIPAddressConfiguration.DeserializeVirtualMachineScaleSetPublicIPAddressConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("privateIPAddressVersion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateIPAddressVersion = new IPVersion(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("applicationGatewayBackendAddressPools"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            applicationGatewayBackendAddressPools = array;
                            continue;
                        }
                        if (property0.NameEquals("applicationSecurityGroups"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            applicationSecurityGroups = array;
                            continue;
                        }
                        if (property0.NameEquals("loadBalancerBackendAddressPools"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            loadBalancerBackendAddressPools = array;
                            continue;
                        }
                        if (property0.NameEquals("loadBalancerInboundNatPools"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            loadBalancerInboundNatPools = array;
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
            return new VirtualMachineScaleSetIPConfiguration(
                id,
                serializedAdditionalRawData,
                name,
                subnet,
                primary,
                publicIPAddressConfiguration,
                privateIPAddressVersion,
                applicationGatewayBackendAddressPools ?? new ChangeTrackingList<WritableSubResource>(),
                applicationSecurityGroups ?? new ChangeTrackingList<WritableSubResource>(),
                loadBalancerBackendAddressPools ?? new ChangeTrackingList<WritableSubResource>(),
                loadBalancerInboundNatPools ?? new ChangeTrackingList<WritableSubResource>());
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

            if (Id != null)
            {
                builder.Append("  id:");
                if (Id.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{Id}'''");
                }
                else
                {
                    builder.AppendLine($" '{Id}'");
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            if (Subnet != null)
            {
                builder.Append("    subnet:");
                AppendChildObject(builder, Subnet, options, 4, false);
            }

            if (Primary.HasValue)
            {
                builder.Append("    primary:");
                var boolValue = Primary.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (PublicIPAddressConfiguration != null)
            {
                builder.Append("    publicIPAddressConfiguration:");
                AppendChildObject(builder, PublicIPAddressConfiguration, options, 4, false);
            }

            if (PrivateIPAddressVersion.HasValue)
            {
                builder.Append("    privateIPAddressVersion:");
                builder.AppendLine($" '{PrivateIPAddressVersion.Value.ToString()}'");
            }

            if (!(ApplicationGatewayBackendAddressPools is ChangeTrackingList<WritableSubResource> collection && collection.IsUndefined))
            {
                if (ApplicationGatewayBackendAddressPools.Any())
                {
                    builder.Append("    applicationGatewayBackendAddressPools:");
                    builder.AppendLine(" [");
                    foreach (var item in ApplicationGatewayBackendAddressPools)
                    {
                        AppendChildObject(builder, item, options, 6, true);
                    }
                    builder.AppendLine("    ]");
                }
            }

            if (!(ApplicationSecurityGroups is ChangeTrackingList<WritableSubResource> collection0 && collection0.IsUndefined))
            {
                if (ApplicationSecurityGroups.Any())
                {
                    builder.Append("    applicationSecurityGroups:");
                    builder.AppendLine(" [");
                    foreach (var item in ApplicationSecurityGroups)
                    {
                        AppendChildObject(builder, item, options, 6, true);
                    }
                    builder.AppendLine("    ]");
                }
            }

            if (!(LoadBalancerBackendAddressPools is ChangeTrackingList<WritableSubResource> collection1 && collection1.IsUndefined))
            {
                if (LoadBalancerBackendAddressPools.Any())
                {
                    builder.Append("    loadBalancerBackendAddressPools:");
                    builder.AppendLine(" [");
                    foreach (var item in LoadBalancerBackendAddressPools)
                    {
                        AppendChildObject(builder, item, options, 6, true);
                    }
                    builder.AppendLine("    ]");
                }
            }

            if (!(LoadBalancerInboundNatPools is ChangeTrackingList<WritableSubResource> collection2 && collection2.IsUndefined))
            {
                if (LoadBalancerInboundNatPools.Any())
                {
                    builder.Append("    loadBalancerInboundNatPools:");
                    builder.AppendLine(" [");
                    foreach (var item in LoadBalancerInboundNatPools)
                    {
                        AppendChildObject(builder, item, options, 6, true);
                    }
                    builder.AppendLine("    ]");
                }
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

        BinaryData IPersistableModel<VirtualMachineScaleSetIPConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetIPConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetIPConfiguration)} does not support '{options.Format}' format.");
            }
        }

        VirtualMachineScaleSetIPConfiguration IPersistableModel<VirtualMachineScaleSetIPConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetIPConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineScaleSetIPConfiguration(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetIPConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineScaleSetIPConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
