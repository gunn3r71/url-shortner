using System.Text;
using UrlShortner.Api.Domain.Common.Validators;

namespace UrlShortner.Api.Domain.Entities;

public class UrlEncurtada
{
    private static Random _random = new();
    private const int NumeroMinimoCaracteres = 5;
    private const int NumeroMaximoCaracteres = 10;

    public UrlEncurtada(string urlOriginal)
    {
        Id = Guid.NewGuid();

        ValidadorUrl.Validar(urlOriginal);
        
        UrlOriginal = urlOriginal;
        
        Codigo = GerarCodigo();
    }

    public Guid Id { get; private set; }
    public string UrlOriginal { get; private set; }
    public string Codigo { get; private set; }

    private string GerarCodigo()
    {
        int tamanhoCodigo = _random.Next(NumeroMinimoCaracteres, NumeroMaximoCaracteres);
        
        string guid = Guid.NewGuid().ToString("N");

        StringBuilder builder = new();

        for (int i = 0; i < tamanhoCodigo; i++) 
            builder.Append(guid[_random.Next(guid.Length)]);

        return builder.ToString();
    }
}