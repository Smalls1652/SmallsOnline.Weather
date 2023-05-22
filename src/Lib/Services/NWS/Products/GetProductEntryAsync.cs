using System.Text.Json;
using SmallsOnline.Weather.Lib.Models.NWS;

namespace SmallsOnline.Weather.Lib.Services.NWS;

public partial class NwsService
{
    public async Task<TextProduct?> GetProductEntryAsync(string productId)
    {
        HttpRequestMessage request = new(
            method: HttpMethod.Get,
            requestUri: $"https://api.weather.gov/products/{productId}"
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
            jsonTypeInfo: _sourceGenerationContext.TextProduct
        );
    }
}