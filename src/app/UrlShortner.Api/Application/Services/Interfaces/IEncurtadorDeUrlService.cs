using UrlShortner.Api.Application.Dtos.Request;
using UrlShortner.Api.Application.Dtos.Response;

namespace UrlShortner.Api.Application.Services.Interfaces;

public interface IEncurtadorDeUrlService
{
    Task<UrlEncurtadaResponse> EncurtarUrlAsync(EncurtarUrlRequest request);
    Task<string> BuscarUrlPorCodigoAsync(string codigo);
}