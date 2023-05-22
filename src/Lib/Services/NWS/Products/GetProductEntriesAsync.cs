using System.Text.Json;
using SmallsOnline.Weather.Lib.Models.NWS;

namespace SmallsOnline.Weather.Lib.Services.NWS;

public partial class NwsService
{
    public async Task<GraphCollection<TextProduct>?> GetProductEntriesAsync(string product, string officeId)
    {
        HttpRequestMessage request = new(
            method: HttpMethod.Get,
            requestUri: $"https://api.weather.gov/products/types/{product}/locations/{officeId}"
        );

        HttpResponseMessage apiResponse = await _httpClient.SendAsync(request);

        string jsonString = await apiResponse.Content.ReadAsStringAsync();

        if (!apiResponse.IsSuccessStatusCode)
        {
            ProblemDetail? problemDetail = ParseForProblemDetail(jsonString);
            throw new NwsApiException($"An error occured getting product info: {problemDetail!.Detail}", problemDetail);
        }

        return JsonSerializer.Deserialize(
            json: jsonString,
            jsonTypeInfo: _sourceGenerationContext.GraphCollectionTextProduct
        );
    }
}