// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using MgmtScopeResource.Models;

namespace MgmtScopeResource
{
    public partial class GuestConfigurationAssignmentData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Properties != null)
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteObjectValue(Properties);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Location != null)
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location);
            }
            writer.WriteEndObject();
        }

        internal static GuestConfigurationAssignmentData DeserializeGuestConfigurationAssignmentData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<GuestConfigurationAssignmentProperties> properties = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> location = default;
            Optional<string> type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = GuestConfigurationAssignmentProperties.DeserializeGuestConfigurationAssignmentProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new GuestConfigurationAssignmentData(id.Value, name.Value, location.Value, type.Value, properties.Value);
        }
    }
}
