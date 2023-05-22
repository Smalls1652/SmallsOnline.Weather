namespace SmallsOnline.Weather.Lib.Models.NWS;

public interface IAlertCollectionGeoJson
{
    string Type { get; set; }
    string Title { get; set; }
    DateTimeOffset LastUpdated { get; set; }
    IEnumerable<GeoJsonFeature<Alert>>? Alerts { get; set; }
    PaginationInfo? Pagination { get; set; }
}