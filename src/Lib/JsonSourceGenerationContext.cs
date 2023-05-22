using System.Text.Json.Serialization;
using SmallsOnline.Weather.Lib.Models.NWS;

namespace SmallsOnline.Weather.Lib;

[JsonSourceGenerationOptions(
    WriteIndented = true,
    PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
    GenerationMode = JsonSourceGenerationMode.Default,
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
)]
[JsonSerializable(typeof(Alert))]
[JsonSerializable(typeof(AlertCollectionGeoJson))]
[JsonSerializable(typeof(GeoJsonGeometry))]
[JsonSerializable(typeof(GeoJsonFeature<Alert>))]
[JsonSerializable(typeof(GeoJsonFeature<Point>))]
[JsonSerializable(typeof(Office))]
[JsonSerializable(typeof(OfficeAddress))]
[JsonSerializable(typeof(OfficeHeadline))]
[JsonSerializable(typeof(OfficeHeadlines))]
[JsonSerializable(typeof(PaginationInfo))]
[JsonSerializable(typeof(Point))]
[JsonSerializable(typeof(ProblemDetail))]
[JsonSerializable(typeof(TextProduct))]
internal partial class JsonSourceGenerationContext : JsonSerializerContext
{
}