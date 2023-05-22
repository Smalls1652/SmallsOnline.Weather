namespace SmallsOnline.Weather.Lib.Services.NWS;

public partial class NwsService : INwsService
{
    private readonly HttpClient _httpClient;
    private readonly JsonSourceGenerationContext _sourceGenerationContext = new();

    public NwsService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.DefaultRequestHeaders.UserAgent.Add(new("SmallsOnline.Weather.Lib", "0.0.1"));
    }

}