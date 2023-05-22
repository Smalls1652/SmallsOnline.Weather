namespace SmallsOnline.Weather.Lib.Models.NWS;

public interface IAlert
{
    string Id { get; set; }
    string AreaDescription { get; set; }
    IEnumerable<string>? AffectedZones { get; set; }
    DateTimeOffset Sent { get; set; }
    DateTimeOffset Effective { get; set; }
    DateTimeOffset Onset { get; set; }
    DateTimeOffset Expires { get; set; }
    DateTimeOffset Ends { get; set; }
    string Status { get; set; }
    string MessageType { get; set; }
    string Category { get; set; }
    string Severity { get; set; }
    string Certainty { get; set; }
    string Urgency { get; set; }
    string Event { get; set; }
    string Sender { get; set; }
    string SenderName { get; set; }
    string? Headline { get; set; }
    string Description { get; set; }
    string? Instruction { get; set; }
    string Response { get; set; }
}