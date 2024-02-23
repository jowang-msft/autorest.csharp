// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    internal partial class StorageSkuListResult
    {
        internal static StorageSkuListResult DeserializeStorageSkuListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<StorageSkuInformation> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StorageSkuInformation> array = new List<StorageSkuInformation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StorageSkuInformation.DeserializeStorageSkuInformation(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new StorageSkuListResult(value ?? new ChangeTrackingList<StorageSkuInformation>());
        }
    }
}
