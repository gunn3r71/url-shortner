using FluentAssertions;
using UrlShortner.Api.Domain.Common.Exceptions;
using UrlShortner.Api.Domain.Entities;

namespace UrlShortner.UnitTests.Domain.Entities;

public class UrlEncurtadaTests
{
    [Fact(DisplayName = "Cenário #1 - Ao criar uma URL encurtada, deve gerar um código com tamanho de 5 a 10 caracteres")]
    [Trait("Category", "success")]
    public void AoSolicitar_UmaUrlEncurtada_Deve_GerarUmCodigo_ComTamanhoDe5A10Caracteres()
    {
        var url = "https://www.teste.com.br";

        var urlEncurtada = new UrlEncurtada(url);

        urlEncurtada.Codigo.Length.Should().BeGreaterOrEqualTo(5).And.BeLessThanOrEqualTo(10);
    }

    [Fact(DisplayName = "Cenário #2 - Ao tentar criar uma URL encurtada com uma URL inválida deve lançar uma exceção de dominio")]
    [Trait("Category", "fail")]
    public void AoSolicitar_UmaUrlEncurtada_E_UrlOriginalForInvalida_Deve_LancarExcecaoDeDominio()
    {
        var url = "htt://----.net";

        var action = () => new UrlEncurtada(url);

        action.Should().ThrowExactly<UrlInvalidaException>();
    }

    [Theory(DisplayName = "Cenário #3 - Ao tentar criar uma URL encurtada com parâmetros validos deve criar com sucesso")]
    [InlineData("https://www.google.com"),
     InlineData("http://meudominio.com.br")]
    public void AoSolicitar_UmaUrlEncurtada_E_ParametrosValidos_Deve_CriarComSucesso(string url)
    {
        var urlEncurtada = new UrlEncurtada(url);

        urlEncurtada.UrlOriginal.Should().Be(url);
        urlEncurtada.Codigo.Should().NotBeEmpty();
        urlEncurtada.Id.Should().NotBeEmpty();
    }
}