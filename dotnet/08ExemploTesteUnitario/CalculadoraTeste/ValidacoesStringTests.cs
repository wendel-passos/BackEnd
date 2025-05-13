using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTeste
{
    public class ValidacoesStringTests
    {
        private ValidacoesString _validacoesString;
        public ValidacoesStringTests()
        {
            _validacoesString = new ValidacoesString();
        }
        [Fact]
        public void DeveContarCaracteresDeUmaString()
        {
            // Arrange
            string texto = "Teste";
            int resultadoEsperado = 5;

            // Act
            int resultado = _validacoesString.ContaCaracteres(texto);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void DeveContarCaracteresDeUmaStringVazia()
        {
            // Arrange
            string texto = "";
            int resultadoEsperado = 0;

            // Act
            int resultado = _validacoesString.ContaCaracteres(texto);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

    }  
    
}
