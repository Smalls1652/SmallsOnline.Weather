using System.Text.Json.Serialization;

namespace SmallsOnline.Weather.Lib.Models.NWS;

public class TextProduct : ITextProduct
{
    [JsonPropertyName("@id")]
    public string ApiId { get; set; } = null!;

    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;

    [JsonPropertyName("wmoCollectiveId")]
    public string WmoCollectiveId { get; set; } = null!;

    [JsonPropertyName("issuingOffice")]
    public string IssuingOffice { get; set; } = null!;

    [JsonPropertyName("issuanceTime")]
    public DateTimeOffset IssuanceTime { get; set; }

    [JsonPropertyName("productCode")]
    public string ProductCode { get; set; } = null!;

    [JsonPropertyName("productName")]
    public string ProductName { get; set; } = null!;

    [JsonPropertyName("productText")]
    public string? ProductText { get; set; }
}