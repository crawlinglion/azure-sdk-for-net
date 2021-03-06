// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Administration.Models
{
    public partial class AreaCodes
    {
        internal static AreaCodes DeserializeAreaCodes(JsonElement element)
        {
            Optional<IReadOnlyList<string>> primaryAreaCodes = default;
            Optional<IReadOnlyList<string>> secondaryAreaCodes = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryAreaCodes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    primaryAreaCodes = array;
                    continue;
                }
                if (property.NameEquals("secondaryAreaCodes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    secondaryAreaCodes = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new AreaCodes(Optional.ToList(primaryAreaCodes), Optional.ToList(secondaryAreaCodes), nextLink.Value);
        }
    }
}
