using System.Text.Json.Serialization;

namespace SmallsOnline.Weather.Lib.Models.NWS;

public class Office : IOffice
{
    [JsonPropertyName("@type")]
    public string Type { get; set; } = null!;

    [JsonPropertyName("@id")]
    public string ApiId { get; set; } = null!;

    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;

    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("address")]
    public OfficeAddress Address { get; set; } = null!;

    [JsonPropertyName("telephone")]
    public string Telephone { get; set; } = null!;

    [JsonPropertyName("faxNumber")]
    public string FaxNumber { get; set; } = null!;

    [JsonPropertyName("email")]
    public string Email { get; set; } = null!;

    [JsonPropertyName("nwsRegion")]
    public string NwsRegion { get; set; } = null!;

    [JsonPropertyName("parentOrganization")]
    public string ParentOrganization { get; set; } = null!;

    [JsonPropertyName("responsibleCounties")]
    public IEnumerable<string>? ResponsibleCounties { get; set; }

    [JsonPropertyName("responsibleForecastZones")]
    public IEnumerable<string>? ResponsibleForecastZones { get; set; }

    [JsonPropertyName("responsibleFireZones")]
    public IEnumerable<string>? ResponsibleFireZones { get; set; }

    [JsonPropertyName("approvedObservationStations")]
    public IEnumerable<string>? ApprovedObservationStations { get; set; }
}