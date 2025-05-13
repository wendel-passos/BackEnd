using Calculadora.Services;
using Xunit;

namespace CalculadoraTeste;

public class CalculadoraTests
{
    private CalculadoraImp _calculadora;
    public CalculadoraTests()
    {
        _calculadora = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        // Arrange
        var calculadora = new Calculadora.Services.CalculadoraImp();
        int num1 = 5;
        int num2 = 10;
        int resultadoEsperado = 15;

        // Act
        int resultado = calculadora.Somar(num1, num2);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        // Arrange
        var calculadora = new Calculadora.Services.CalculadoraImp();
        int num1 = 10;
        int num2 = 10;
        int resultadoEsperado = 20;

        // Act
        int resultado = calculadora.Somar(num1, num2);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);

    }
    [Fact]
    public void DeveVerificarSe4EhParERetornarVerdadeiro()
    {
        // Arrange
        int num = 4;

        // Act
        bool resultado = _calculadora.EhPar(num);

        // Assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(new int[] { 2, 4, 6, 8, 10 })]
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int[] numeros)
    {
        // Act / Assert
        Assert.All(numeros, num => Assert.True(_calculadora.EhPar(num)));
    }
}