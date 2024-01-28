using System.ComponentModel.DataAnnotations;

namespace UrlShortner.Api.Application.Dtos.Request;

public class EncurtarUrlRequest
{
    [Required(ErrorMessage = "Parâmetro {0} deve ser informado.")]
    public string UrlOriginal { get; set; }
}