using System.Text.Json.Serialization;

namespace SmallsOnline.Weather.Lib.Models.NWS;

public class GraphCollection<T> : IGraphCollection<T>
{
    [JsonPropertyName("@graph")]
    public IEnumerable<T>? Values { get; set; }
}