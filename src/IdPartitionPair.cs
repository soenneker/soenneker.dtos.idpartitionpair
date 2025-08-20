using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Dtos.IdPartitionPair;

/// <summary>
/// A minimal Record type with an Id (string), PartitionKey (string), and maximum JSON compatibility. <para/>
/// Properties are non-nullable. Lowercase properties when (de)serialized.
/// </summary>
[PublicOpenApiObject]
public record IdPartitionPair
{
    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public required string Id { get; set; } = null!;

    [JsonPropertyName("partitionKey")]
    [JsonProperty("partitionKey")]
    public required string PartitionKey { get; set; } = null!;
}