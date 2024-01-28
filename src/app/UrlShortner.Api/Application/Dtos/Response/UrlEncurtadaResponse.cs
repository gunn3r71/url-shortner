namespace UrlShortner.Api.Application.Dtos.Response;

public class UrlEncurtadaResponse
{
    public UrlEncurtadaResponse(string codigo)
    {
        Codigo = codigo;
    }

    public string Codigo { get; private set; }
}