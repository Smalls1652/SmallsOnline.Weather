using System.Text.Json.Serialization;

namespace SmallsOnline.Weather.Lib.Models.NWS;

public class OfficeAddress : IOfficeAddress
{
    [JsonPropertyName("@type")]
    public string Type { get; set; } = null!;

    [JsonPropertyName("streetAddress")]
    public string StreetAddress { get; set; } = null!;

    [JsonPropertyName("addressLocality")]
    public string AddressLocality { get; set; } = null!;

    [JsonPropertyName("addressRegion")]
    public string AddressRegion { get; set; } = null!;

    [JsonPropertyName("postalCode")]
    public string PostalCode { get; set; } = null!;
}