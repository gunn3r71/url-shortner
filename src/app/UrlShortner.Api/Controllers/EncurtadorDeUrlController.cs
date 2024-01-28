using Microsoft.AspNetCore.Mvc;
using UrlShortner.Api.Application.Dtos.Request;
using UrlShortner.Api.Application.Dtos.Response;
using UrlShortner.Api.Application.Services.Interfaces;

namespace UrlShortner.Api.Controllers;

[ApiController]
[Route("encurtador-de-url")]
public class EncurtadorDeUrlController : ControllerBase
{
    private readonly IEncurtadorDeUrlService _service;

    public EncurtadorDeUrlController(IEncurtadorDeUrlService service)
    {
        _service = service;
    }

    [HttpPost]
    [ProducesResponseType(typeof(UrlEncurtadaResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponse<string>), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse<string>), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> EncurtarUrlAsync([FromBody] EncurtarUrlRequest request)
    {
        var response = await _service.EncurtarUrlAsync(request);

        return Ok(response);
    }

    [HttpGet("{codigo:required:minlength(5):maxlength(10)}")]
    [ProducesResponseType(StatusCodes.Status302Found)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorResponse<string>), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> BuscarUrlPorCodigoAsync([FromRoute] string codigo)
    {
        var response = await _service.BuscarUrlPorCodigoAsync(codigo);
        
        return Redirect(response);
    }
}
