namespace SmallsOnline.Weather.Lib.Models.NWS;

public interface IPointGeoJson
{
    string Id { get; set; }
    string Type { get; set; }
    GeoJsonGeometry Geometry { get; set; }

}