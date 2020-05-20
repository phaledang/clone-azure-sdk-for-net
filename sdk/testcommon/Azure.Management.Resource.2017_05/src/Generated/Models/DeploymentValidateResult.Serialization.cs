// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Resource.Models
{
    public partial class DeploymentValidateResult
    {
        internal static DeploymentValidateResult DeserializeDeploymentValidateResult(JsonElement element)
        {
            ResourceManagementErrorWithDetails error = default;
            DeploymentPropertiesExtended properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = ResourceManagementErrorWithDetails.DeserializeResourceManagementErrorWithDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = DeploymentPropertiesExtended.DeserializeDeploymentPropertiesExtended(property.Value);
                    continue;
                }
            }
            return new DeploymentValidateResult(error, properties);
        }
    }
}
