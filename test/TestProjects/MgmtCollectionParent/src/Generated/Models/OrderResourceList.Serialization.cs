// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace MgmtCollectionParent.Models
{
    internal partial class OrderResourceList
    {
        internal static OrderResourceList DeserializeOrderResourceList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<OrderResourceData> value = default;
            string nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OrderResourceData> array = new List<OrderResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OrderResourceData.DeserializeOrderResourceData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new OrderResourceList(value ?? new ChangeTrackingList<OrderResourceData>(), nextLink);
        }
    }
}