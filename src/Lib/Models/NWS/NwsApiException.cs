namespace SmallsOnline.Weather.Lib.Models.NWS;

public class NwsApiException : Exception
{
    public NwsApiException()
    {}

    public NwsApiException(string message, ProblemDetail problemDetail) : base(message)
    {
        NwsApiProblemDetail = problemDetail;
    }

    public NwsApiException(string message, ProblemDetail problemDetail, Exception innerException) : base(message, innerException)
    {
        NwsApiProblemDetail = problemDetail;
    }

    public ProblemDetail? NwsApiProblemDetail { get; }
}