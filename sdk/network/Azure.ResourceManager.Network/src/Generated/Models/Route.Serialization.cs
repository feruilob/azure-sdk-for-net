// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class Route : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Etag != null)
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (AddressPrefix != null)
            {
                writer.WritePropertyName("addressPrefix");
                writer.WriteStringValue(AddressPrefix);
            }
            if (NextHopType != null)
            {
                writer.WritePropertyName("nextHopType");
                writer.WriteStringValue(NextHopType.Value.ToString());
            }
            if (NextHopIpAddress != null)
            {
                writer.WritePropertyName("nextHopIpAddress");
                writer.WriteStringValue(NextHopIpAddress);
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static Route DeserializeRoute(JsonElement element)
        {
            string name = default;
            string etag = default;
            string id = default;
            string addressPrefix = default;
            RouteNextHopType? nextHopType = default;
            string nextHopIpAddress = default;
            ProvisioningState? provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("addressPrefix"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            addressPrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nextHopType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nextHopType = new RouteNextHopType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("nextHopIpAddress"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nextHopIpAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new Route(id, name, etag, addressPrefix, nextHopType, nextHopIpAddress, provisioningState);
        }
    }
}