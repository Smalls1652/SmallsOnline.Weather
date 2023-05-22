using System.Text.Json.Serialization;

namespace SmallsOnline.Weather.Lib.Models.NWS;

public class Alert : IAlert
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;

    [JsonPropertyName("areaDesc")]
    public string AreaDescription { get; set; } = null!;

    [JsonPropertyName("affectedZones")]
    public IEnumerable<string>? AffectedZones { get; set; }

    [JsonPropertyName("sent")]
    public DateTimeOffset Sent { get; set; }

    [JsonPropertyName("effective")]
    public DateTimeOffset Effective { get; set; }

    [JsonPropertyName("onset")]
    public DateTimeOffset Onset { get; set; }

    [JsonPropertyName("expires")]
    public DateTimeOffset Expires { get; set; }

    [JsonPropertyName("ends")]
    public DateTimeOffset Ends { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; } = null!;

    [JsonPropertyName("messageType")]
    public string MessageType { get; set; } = null!;

    [JsonPropertyName("category")]
    public string Category { get; set; } = null!;

    [JsonPropertyName("severity")]
    public string Severity { get; set; } = null!;

    [JsonPropertyName("certainty")]
    public string Certainty { get; set; } = null!;

    [JsonPropertyName("urgency")]
    public string Urgency { get; set; } = null!;

    [JsonPropertyName("event")]
    public string Event { get; set; } = null!;

    [JsonPropertyName("sender")]
    public string Sender { get; set; } = null!;

    [JsonPropertyName("senderName")]
    public string SenderName { get; set; } = null!;

    [JsonPropertyName("headline")]
    public string? Headline { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; } = null!;

    [JsonPropertyName("instruction")]
    public string? Instruction { get; set; }

    [JsonPropertyName("response")]
    public string Response { get; set; } = null!;
}