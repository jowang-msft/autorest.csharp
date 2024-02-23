// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sample.Models
{
    public partial class VirtualMachineScaleSetUpdateStorageProfile : IUtf8JsonSerializable, IJsonModel<VirtualMachineScaleSetUpdateStorageProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineScaleSetUpdateStorageProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualMachineScaleSetUpdateStorageProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetUpdateStorageProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetUpdateStorageProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ImageReference != null)
            {
                writer.WritePropertyName("imageReference"u8);
                writer.WriteObjectValue(ImageReference);
            }
            if (OSDisk != null)
            {
                writer.WritePropertyName("osDisk"u8);
                writer.WriteObjectValue(OSDisk);
            }
            if (!(DataDisks is ChangeTrackingList<VirtualMachineScaleSetDataDisk> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("dataDisks"u8);
                writer.WriteStartArray();
                foreach (var item in DataDisks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
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

        VirtualMachineScaleSetUpdateStorageProfile IJsonModel<VirtualMachineScaleSetUpdateStorageProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetUpdateStorageProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetUpdateStorageProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineScaleSetUpdateStorageProfile(document.RootElement, options);
        }

        internal static VirtualMachineScaleSetUpdateStorageProfile DeserializeVirtualMachineScaleSetUpdateStorageProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ImageReference> imageReference = default;
            Optional<VirtualMachineScaleSetUpdateOSDisk> osDisk = default;
            IList<VirtualMachineScaleSetDataDisk> dataDisks = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("imageReference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    imageReference = ImageReference.DeserializeImageReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("osDisk"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osDisk = VirtualMachineScaleSetUpdateOSDisk.DeserializeVirtualMachineScaleSetUpdateOSDisk(property.Value, options);
                    continue;
                }
                if (property.NameEquals("dataDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VirtualMachineScaleSetDataDisk> array = new List<VirtualMachineScaleSetDataDisk>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualMachineScaleSetDataDisk.DeserializeVirtualMachineScaleSetDataDisk(item, options));
                    }
                    dataDisks = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VirtualMachineScaleSetUpdateStorageProfile(imageReference.Value, osDisk.Value, dataDisks ?? new ChangeTrackingList<VirtualMachineScaleSetDataDisk>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualMachineScaleSetUpdateStorageProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetUpdateStorageProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetUpdateStorageProfile)} does not support '{options.Format}' format.");
            }
        }

        VirtualMachineScaleSetUpdateStorageProfile IPersistableModel<VirtualMachineScaleSetUpdateStorageProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetUpdateStorageProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineScaleSetUpdateStorageProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetUpdateStorageProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineScaleSetUpdateStorageProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
