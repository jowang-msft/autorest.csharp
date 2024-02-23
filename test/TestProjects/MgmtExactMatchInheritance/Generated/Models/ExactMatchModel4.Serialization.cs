// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace MgmtExactMatchInheritance.Models
{
    public partial class ExactMatchModel4 : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (New != null)
            {
                writer.WritePropertyName("new"u8);
                writer.WriteStringValue(New);
            }
            if (Id.HasValue)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteNumberValue(Id.Value);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (ExactMatchModel9Type != null)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ExactMatchModel9Type);
            }
            writer.WriteEndObject();
        }

        internal static ExactMatchModel4 DeserializeExactMatchModel4(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> @new = default;
            Optional<int> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("new"u8))
                {
                    @new = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new ExactMatchModel4(Optional.ToNullable(id), name.Value, type.Value, @new.Value);
        }
    }
}
