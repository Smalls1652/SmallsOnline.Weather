using SmallsOnline.Weather.Lib.Models.NWS;

namespace SmallsOnline.Weather.Lib.Services.NWS;

public interface INwsService
{
    // API endpoints: /offices
    Task<Office?> GetOfficeAsync(string officeId);

    // API endpoints: /points
    Task<GeoJsonFeature<Point>?> GetPointInfoAsync(string latitude, string longitude);

    // API endpoints: /products
    Task<GraphCollection<TextProduct>?> GetProductEntriesAsync(string product, string officeId);
    Task<TextProduct?> GetProductEntryAsync(string productId);
}