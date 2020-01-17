// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;
using Azure.Core;

namespace body_complex.Models
{
    public partial class DateWrapper : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Field != null)
            {
                writer.WritePropertyName("field");
                writer.WriteStringValue(Field.Value, "D");
            }
            if (Leap != null)
            {
                writer.WritePropertyName("leap");
                writer.WriteStringValue(Leap.Value, "D");
            }
            writer.WriteEndObject();
        }
        internal static DateWrapper DeserializeDateWrapper(JsonElement element)
        {
            DateWrapper result = new DateWrapper();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("field"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Field = property.Value.GetDateTimeOffset("D");
                    continue;
                }
                if (property.NameEquals("leap"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Leap = property.Value.GetDateTimeOffset("D");
                    continue;
                }
            }
            return result;
        }
    }
}
