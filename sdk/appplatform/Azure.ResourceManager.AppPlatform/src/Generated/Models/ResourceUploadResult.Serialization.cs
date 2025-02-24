// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class ResourceUploadResult
    {
        internal static ResourceUploadResult DeserializeResourceUploadResult(JsonElement element)
        {
            Optional<string> relativePath = default;
            Optional<Uri> uploadUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("relativePath"))
                {
                    relativePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("uploadUrl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        uploadUri = null;
                        continue;
                    }
                    uploadUri = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new ResourceUploadResult(relativePath.Value, uploadUri.Value);
        }
    }
}
