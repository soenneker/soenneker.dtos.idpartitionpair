using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Soenneker.Dtos.IdPartitionPair;

/// <summary>
/// A minimal Record type with an Id (string), PartitionKey (string), and maximum JSON compatibility. <para/>
/// Properties are non-nullable. Lowercase properties when (de)serialized.
/// </summary>
[DataContract]
public record IdPartitionPair
{
    [DataMember(Name = "id")]
    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public string Id { get; set; } = default!;

    [DataMember(Name = "partitionKey")]
    [JsonPropertyName("partitionKey")]
    [JsonProperty("partitionKey")]
    public string PartitionKey { get; set; } = default!;
}