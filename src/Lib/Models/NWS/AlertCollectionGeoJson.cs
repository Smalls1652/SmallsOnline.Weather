using System.Text.Json.Serialization;

namespace SmallsOnline.Weather.Lib.Models.NWS;

public class AlertCollectionGeoJson : IAlertCollectionGeoJson
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("updated")]
    public DateTimeOffset LastUpdated { get; set; }

    [JsonPropertyName("features")]
    public IEnumerable<GeoJsonFeature<Alert>>? Alerts { get; set; }

    [JsonPropertyName("pagination")]
    public PaginationInfo? Pagination { get; set; }
}