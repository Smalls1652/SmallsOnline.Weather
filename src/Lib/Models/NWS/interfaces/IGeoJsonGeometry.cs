namespace SmallsOnline.Weather.Lib.Models.NWS;

public interface IGeoJsonGeometry
{
    string Type { get; set; }
    IEnumerable<string>? Coordinates { get; set; }
}