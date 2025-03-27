using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Soenneker.Dtos.IdPartitionPair;

/// <summary>
/// A minimal Record type with an Id (string), PartitionKey (string), and maximum JSON compatibility. <para/>
/// Properties are non-nullable. Lowercase properties when (de)serialized.
/// </summary>
public record IdPartitionPair
{
    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public string Id { get; set; } = null!;

    [JsonPropertyName("partitionKey")]
    [JsonProperty("partitionKey")]
    public string PartitionKey { get; set; } = null!;
}