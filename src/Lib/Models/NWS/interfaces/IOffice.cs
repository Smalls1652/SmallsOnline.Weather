namespace SmallsOnline.Weather.Lib.Models.NWS;

public interface IOffice
{
    string Type { get; set; }
    string ApiId { get; set; }
    string Id { get; set; }
    string Name { get; set; }
    OfficeAddress Address { get; set; }
    string Telephone { get; set; }
    string FaxNumber { get; set; }
    string Email { get; set; }
    string NwsRegion { get; set; }
    string ParentOrganization { get; set; }
    IEnumerable<string>? ResponsibleCounties { get; set; }
    IEnumerable<string>? ResponsibleForecastZones { get; set; }
    IEnumerable<string>? ResponsibleFireZones { get; set; }
    IEnumerable<string>? ApprovedObservationStations { get; set; }
}