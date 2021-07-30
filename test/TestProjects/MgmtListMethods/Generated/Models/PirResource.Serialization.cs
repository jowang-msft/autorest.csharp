// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace MgmtListMethods.Models
{
    public partial class PirResource
    {
        internal static PirResource DeserializePirResource(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> location = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
            }
            return new PirResource(name.Value, location.Value);
        }
    }
}