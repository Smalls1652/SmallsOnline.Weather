using System.Text.Json.Serialization;

namespace SmallsOnline.Weather.Lib.Models.NWS;

public class GeoJsonFeature<T> : IGeoJsonFeature<T>
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;

    [JsonPropertyName("type")]
    public string Type { get; set; } = null!;

    [JsonPropertyName("geometry")]
    public GeoJsonGeometry Geometry { get; set; } = null!;

    [JsonPropertyName("properties")]
    public T? Properties { get; set; }
}