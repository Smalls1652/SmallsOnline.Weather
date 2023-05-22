using System.Text.Json.Serialization;

namespace SmallsOnline.Weather.Lib.Models.NWS;

public class ProblemDetail : IProblemDetail
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = null!;

    [JsonPropertyName("title")]
    public string Title { get; set; } = null!;

    [JsonPropertyName("status")]
    public int Status { get; set; }

    [JsonPropertyName("detail")]
    public string Detail { get; set; } = null!;

    [JsonPropertyName("instance")]
    public string Instance { get; set; } = null!;

    [JsonPropertyName("correlationId")]
    public string CorrelationId { get; set; } = null!;
}