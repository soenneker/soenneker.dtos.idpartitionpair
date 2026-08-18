using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Dtos.IdPartitionPair;

/// <summary>
/// Identifies a partitioned record by its resource identifier and partition key.
/// </summary>
[PublicOpenApiObject]
public record IdPartitionPair
{
    /// <summary>
    /// Stable identifier of the record within its partition.
    /// </summary>
    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public required string Id { get; set; } = null!;

    /// <summary>
    /// Partition key used to locate and route the record in the backing data store.
    /// </summary>
    [JsonPropertyName("partitionKey")]
    [JsonProperty("partitionKey")]
    public required string PartitionKey { get; set; } = null!;
}
