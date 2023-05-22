using System.Text.Json.Serialization;

namespace SmallsOnline.Weather.Lib.Models.NWS;

public class OfficeHeadlines : IOfficeGraphCollection<OfficeHeadline>
{
    [JsonPropertyName("@graph")]
    public IEnumerable<OfficeHeadline>? Headlines { get; set; }
}