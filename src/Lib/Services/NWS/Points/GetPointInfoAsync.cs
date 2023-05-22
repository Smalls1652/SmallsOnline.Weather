using System.Net.Http.Headers;
using System.Text.Json;
using SmallsOnline.Weather.Lib.Models.NWS;

namespace SmallsOnline.Weather.Lib.Services.NWS;

public partial class NwsService : INwsService
{
    public async Task<GeoJsonFeature<Point>?> GetPointInfoAsync(string latitude, string longitude)
    {
        HttpRequestMessage request = new(
            method: HttpMethod.Get,
            requestUri: $"https://api.weather.gov/points/{latitude},{longitude}"
        );
        request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/geo+json"));

        HttpResponseMessage apiResponse = await _httpClient.SendAsync(request);

        string jsonString = await apiResponse.Content.ReadAsStringAsync();

        if (!apiResponse.IsSuccessStatusCode)
        {
            ProblemDetail? problemDetail = ParseForProblemDetail(jsonString);
            throw new NwsApiException($"An error occurred getting point data: {problemDetail!.Detail}", problemDetail);
        }

        return JsonSerializer.Deserialize(
            json: jsonString,
            jsonTypeInfo: _sourceGenerationContext.GeoJsonFeaturePoint
        );
    }
}