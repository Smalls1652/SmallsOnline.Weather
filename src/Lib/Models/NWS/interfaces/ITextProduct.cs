namespace SmallsOnline.Weather.Lib.Models.NWS;

public interface ITextProduct
{
    string ApiId { get; set; }
    string Id { get; set; }
    string WmoCollectiveId { get; set; }
    string IssuingOffice { get; set; }
    DateTimeOffset IssuanceTime { get; set; }
    string ProductCode { get; set; }
    string ProductName { get; set; }
    string? ProductText { get; set; }
}