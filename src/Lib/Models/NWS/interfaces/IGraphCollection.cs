namespace SmallsOnline.Weather.Lib.Models.NWS;

public interface IGraphCollection<T>
{
    IEnumerable<T>? Values { get; set; }
}