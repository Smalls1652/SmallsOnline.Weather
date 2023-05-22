namespace SmallsOnline.Weather.Lib.Models.NWS;

public interface IOfficeAddress
{
    string Type { get; set; }
    string StreetAddress { get; set; }
    string AddressLocality { get; set; }
    string AddressRegion { get; set; }
    string PostalCode { get; set; }
}