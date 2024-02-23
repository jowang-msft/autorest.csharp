// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace ModelWithConverterUsage.Models
{
    [JsonConverter(typeof(InputModelConverter))]
    public partial class InputModel : IUtf8JsonSerializable, IJsonModel<InputModel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InputModel>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InputModel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InputModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InputModel)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (InputModelProperty != null)
            {
                writer.WritePropertyName("Input_Model_Property"u8);
                writer.WriteStringValue(InputModelProperty);
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

        InputModel IJsonModel<InputModel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InputModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InputModel)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInputModel(document.RootElement, options);
        }

        internal static InputModel DeserializeInputModel(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> inputModelProperty = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Input_Model_Property"u8))
                {
                    inputModelProperty = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InputModel(inputModelProperty.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InputModel>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InputModel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InputModel)} does not support '{options.Format}' format.");
            }
        }

        InputModel IPersistableModel<InputModel>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InputModel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInputModel(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InputModel)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<InputModel>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal partial class InputModelConverter : JsonConverter<InputModel>
        {
            public override void Write(Utf8JsonWriter writer, InputModel model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override InputModel Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeInputModel(document.RootElement);
            }
        }
    }
}
