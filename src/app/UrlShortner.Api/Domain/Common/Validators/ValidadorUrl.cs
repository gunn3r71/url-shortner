using UrlShortner.Api.Domain.Common.Exceptions;
using static UrlShortner.Api.Domain.Common.Validators.CommonRegex;

namespace UrlShortner.Api.Domain.Common.Validators;

public static class ValidadorUrl
{
    public static void Validar(string url)
    {
        if (UrlValidation.IsMatch(url))
            return;

        throw new UrlInvalidaException();
    }
}