namespace SmallsOnline.Weather.Lib.Models.NWS;

public interface IGeoJsonFeature<T>
{
    string Id { get; set; }
    string Type { get; set; }
    GeoJsonGeometry Geometry { get; set; }
    T? Properties { get; set; }
}