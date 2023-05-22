namespace SmallsOnline.Weather.Lib.Models.NWS;

public interface IOfficeGraphCollection<T>
{
    IEnumerable<T>? Headlines { get; set; }
}