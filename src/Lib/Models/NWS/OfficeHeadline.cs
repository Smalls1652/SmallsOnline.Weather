using System.Text.Json.Serialization;

namespace SmallsOnline.Weather.Lib.Models.NWS;

public class OfficeHeadline : IOfficeHeadline
{
    [JsonPropertyName("@id")]
    public string ApiId { get; set; } = null!;

    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;

    [JsonPropertyName("office")]
    public string Office { get; set; } = null!;

    [JsonPropertyName("important")]
    public bool IsImportant { get; set; }

    [JsonPropertyName("issuanceTime")]
    public DateTimeOffset IssuanceTime { get; set; }

    [JsonPropertyName("link")]
    public string Link { get; set; } = null!;

    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("title")]
    public string Title { get; set; } = null!;

    [JsonPropertyName("summary")]
    public string Summary { get; set; } = null!;

    [JsonPropertyName("content")]
    public string Content { get; set; } = null!;
}