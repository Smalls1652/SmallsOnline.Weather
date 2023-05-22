using System.Text.Json.Serialization;

namespace SmallsOnline.Weather.Lib.Models.NWS;

public class PaginationInfo : IPaginationInfo
{
    [JsonPropertyName("next")]
    public string? Next { get; set; }
}