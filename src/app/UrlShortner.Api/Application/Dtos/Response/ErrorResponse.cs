namespace UrlShortner.Api.Application.Dtos.Response;

public class ErrorResponse<T> where T : class
{
    public T Erro { get; set; }
}