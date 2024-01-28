using Microsoft.Extensions.Caching.Distributed;
using UrlShortner.Api.Application.Dtos.Request;
using UrlShortner.Api.Application.Dtos.Response;
using UrlShortner.Api.Application.Services.Interfaces;
using UrlShortner.Api.Domain.Entities;

namespace UrlShortner.Api.Application.Services;

public class EncurtadorDeUrlService : IEncurtadorDeUrlService
{
    private readonly IDistributedCache _cache;

    public EncurtadorDeUrlService(IDistributedCache cache)
    {
        _cache = cache;
    }

    public async Task<UrlEncurtadaResponse> EncurtarUrlAsync(EncurtarUrlRequest request)
    {
        UrlEncurtada urlEncurtada = new(request.UrlOriginal);

        await _cache.SetStringAsync(urlEncurtada.Codigo, request.UrlOriginal);
        
        return new UrlEncurtadaResponse(urlEncurtada.Codigo);
    }

    public async Task<string> BuscarUrlPorCodigoAsync(string codigo)
    {
        string url = await _cache.GetStringAsync(codigo);

        if (!Uri.TryCreate(url, UriKind.Absolute, out _))
            return null;

        return url;
    }
}