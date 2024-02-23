// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using MgmtMockAndSample;

namespace MgmtMockAndSample.Models
{
    internal partial class DeletedVaultListResult
    {
        internal static DeletedVaultListResult DeserializeDeletedVaultListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<DeletedVaultData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DeletedVaultData> array = new List<DeletedVaultData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeletedVaultData.DeserializeDeletedVaultData(item));
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
            return new DeletedVaultListResult(value ?? new ChangeTrackingList<DeletedVaultData>(), nextLink.Value);
        }
    }
}
