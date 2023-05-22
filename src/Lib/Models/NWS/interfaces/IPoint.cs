namespace SmallsOnline.Weather.Lib.Models.NWS;

public interface IPoint
{
    string ApiId { get; set; }
    string Type { get; set; }
    string Cwa { get; set; }
    string ForecastOffice { get; set; }
    string GridId { get; set; }
    int GridX { get; set; }
    int GridY { get; set; }
    string Forecast { get; set; }
    string ForecastHourly { get; set; }
    string ForecastGridData { get; set; }
    string ObservationStations { get; set; }
    string ForecastZone { get; set; }
    string ForecastZoneId { get; }
    string County { get; set; }
    string FireWeatherZone { get; set; }
    string TimeZone { get; set; }
    string RadarStation { get; set; }
}