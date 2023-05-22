using System.Text.Json.Serialization;

namespace SmallsOnline.Weather.Lib.Models.NWS;

public class Point : IPoint
{
    [JsonPropertyName("@id")]
    public string? ApiId { get; set; } 

    [JsonPropertyName("@type")]
    public string? Type { get; set; } 

    [JsonPropertyName("cwa")]
    public string? ForecastOfficeId { get; set; }

    [JsonPropertyName("forecastOffice")]
    public string? ForecastOffice { get; set; } 

    [JsonPropertyName("gridId")]
    public string? GridId { get; set; } 

    [JsonPropertyName("gridX")]
    public int GridX { get; set; }

    [JsonPropertyName("gridY")]
    public int GridY { get; set; }

    [JsonPropertyName("forecast")]
    public string? Forecast { get; set; } 

    [JsonPropertyName("forecastHourly")]
    public string? ForecastHourly { get; set; } 

    [JsonPropertyName("forecastGridData")]
    public string? ForecastGridData { get; set; } 

    [JsonPropertyName("observationStations")]
    public string? ObservationStations { get; set; } 

    [JsonPropertyName("forecastZone")]
    public string? ForecastZone { get; set; }

    [JsonPropertyName("county")]
    public string? County { get; set; } 

    [JsonPropertyName("fireWeatherZone")]
    public string? FireWeatherZone { get; set; } 

    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; } 

    [JsonPropertyName("radarStation")]
    public string? RadarStation { get; set; } 
}