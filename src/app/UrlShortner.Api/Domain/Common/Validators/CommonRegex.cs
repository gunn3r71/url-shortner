using System.Text.RegularExpressions;

namespace UrlShortner.Api.Domain.Common.Validators;

public static class CommonRegex
{
    public static readonly Regex UrlValidation = new(@"^(https?://)?([\da-z.-]+)\.([a-z.]{2,6})([/\w .-]*)*/?$");
}