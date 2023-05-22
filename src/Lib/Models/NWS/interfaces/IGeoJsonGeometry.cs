namespace SmallsOnline.Weather.Lib.Models.NWS;

public interface IGeoJsonGeometry
{
    string Type { get; set; }
    IEnumerable<double>? Coordinates { get; set; }
}