namespace UrlShortner.Api.Domain.Common.Exceptions;

public class UrlInvalidaException : DomainException
{
    public UrlInvalidaException(string mensagem = "A URL informada é invalida.") : base(mensagem)
    {
    }
}