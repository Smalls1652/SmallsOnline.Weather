using System.Text.Json.Serialization;

namespace SmallsOnline.Weather.Lib.Models.NWS;

public class Point : IPoint
{
    [JsonPropertyName("@id")]
    public string ApiId { get; set; } = null!;

    [JsonPropertyName("@type")]
    public string Type { get; set; } = null!;

    [JsonPropertyName("cwa")]
    public string Cwa { get; set; } = null!;

    [JsonPropertyName("forecastOffice")]
    public string ForecastOffice { get; set; } = null!;

    [JsonPropertyName("gridId")]
    public string GridId { get; set; } = null!;

    [JsonPropertyName("gridX")]
    public int GridX { get; set; }

    [JsonPropertyName("gridY")]
    public int GridY { get; set; }

    [JsonPropertyName("forecast")]
    public string Forecast { get; set; } = null!;

    [JsonPropertyName("forecastHourly")]
    public string ForecastHourly { get; set; } = null!;

    [JsonPropertyName("forecastGridData")]
    public string ForecastGridData { get; set; } = null!;

    [JsonPropertyName("observationStations")]
    public string ObservationStations { get; set; } = null!;

    [JsonPropertyName("forecastZone")]
    public string ForecastZone { get; set; } = null!;

    [JsonIgnore]
    public string ForecastZoneId => ForecastZone.Split('/').Last();

    [JsonPropertyName("county")]
    public string County { get; set; } = null!;

    [JsonPropertyName("fireWeatherZone")]
    public string FireWeatherZone { get; set; } = null!;

    [JsonPropertyName("timeZone")]
    public string TimeZone { get; set; } = null!;

    [JsonPropertyName("radarStation")]
    public string RadarStation { get; set; } = null!;
}