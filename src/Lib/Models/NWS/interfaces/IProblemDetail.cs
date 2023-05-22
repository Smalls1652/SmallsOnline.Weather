namespace SmallsOnline.Weather.Lib.Models.NWS;

public interface IProblemDetail
{
    string Type { get; set; }
    string Title { get; set; }
    int Status { get; set; }
    string Detail { get; set; }
    string Instance { get; set; }
    string CorrelationId { get; set; }
}