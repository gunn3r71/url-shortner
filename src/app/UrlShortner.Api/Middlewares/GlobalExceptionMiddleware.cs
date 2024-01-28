using UrlShortner.Api.Application.Dtos.Response;
using UrlShortner.Api.Domain.Common.Exceptions;

namespace UrlShortner.Api.Middlewares;

public class GlobalExceptionMiddleware
{
    private readonly RequestDelegate _next;

    public GlobalExceptionMiddleware(RequestDelegate next)
    {
        _next = next ?? throw new ArgumentNullException(nameof(next));
    }
    
    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(context, ex);
        }
    }

    private Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        context.Response.ContentType = "application/json";
        ErrorResponse<string> response = new ErrorResponse<string>();

        switch (exception)
        {
            case UrlInvalidaException ex:
                response.Erro = ex.Message;
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
                break;
            default:
                response.Erro =
                    "Parece que houve um problema ao processar sua solicitação. Tente novamente mais tarde =/";
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                break;
        }

        return context.Response.WriteAsJsonAsync(response);
    }
}