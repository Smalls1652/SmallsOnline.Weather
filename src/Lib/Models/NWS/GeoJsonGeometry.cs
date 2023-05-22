using System.Text.Json.Serialization;

namespace SmallsOnline.Weather.Lib.Models.NWS;

public class GeoJsonGeometry : IGeoJsonGeometry
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = null!;

    [JsonPropertyName("coordinates")]
    public IEnumerable<double>? Coordinates { get; set; }
}