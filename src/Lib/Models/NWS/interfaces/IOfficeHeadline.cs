namespace SmallsOnline.Weather.Lib.Models.NWS;

public interface IOfficeHeadline
{
    string ApiId { get; set; }
    string Id { get; set; }
    string Office { get; set; }
    bool IsImportant { get; set; }
    DateTimeOffset IssuanceTime { get; set; }
    string Link { get; set; }
    string Name { get; set; }
    string Title { get; set; }
    string Summary { get; set; }
    string Content { get; set; }
}