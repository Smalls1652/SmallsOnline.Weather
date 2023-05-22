using System.Net.Http.Headers;
using System.Text.Json;
using SmallsOnline.Weather.Lib.Models.NWS;

namespace SmallsOnline.Weather.Lib.Services.NWS;

public partial class NwsService
{
    public async Task<Office?> GetOfficeAsync(string officeId)
    {
        HttpRequestMessage request = new(
            method: HttpMethod.Get,
            requestUri: $"https://api.weather.gov/offices/{officeId}"
        );

        HttpResponseMessage apiResponse = await _httpClient.SendAsync(request);

        string jsonString = await apiResponse.Content.ReadAsStringAsync();

        if (!apiResponse.IsSuccessStatusCode)
        {
            ProblemDetail? problemDetail = ParseForProblemDetail(jsonString);
            throw new NwsApiException($"An error occured getting forecast office data: {problemDetail!.Detail}", problemDetail);
        }

        return JsonSerializer.Deserialize(
            json: jsonString,
            jsonTypeInfo: _sourceGenerationContext.Office
        );
    }
}