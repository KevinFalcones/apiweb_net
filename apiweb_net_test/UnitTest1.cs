using System;
using Xunit;
using API;

namespace apiweb_net_test
{
    public class MathTest
    {
        /*
        Arrange [Organizar] : aqu� es donde normalmente preparar�a todo para la prueba, en otras palabras, prepare la escena para la prueba (creando los objetos y configur�ndolos seg�n sea necesario)

        Act [Actuar] : aqu� es donde se ejecuta el m�todo que estamos probando.

        Assert [Afirmar] : esta es la parte final de la prueba en la que comparamos lo que esperamos que suceda con el resultado real de la ejecuci�n del m�todo de prueba.
        */
        
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-4, -6, -10)]
        [InlineData(-2, 2, 0)]
        [InlineData(1.5, 1.5, 3.0)]
        public void Add_ReturnsOkResult(decimal testValue1, decimal testValue2, decimal expectedResult)
        {
            // Act
            decimal okResult = API.Math.Add(testValue1, testValue2);

            // Assert
            Assert.Equal(expectedResult, okResult);
        }

        [Fact]
        public void Add_ReturnsErrResult()
        {
            // Arrange
            decimal testValue1 = 1;
            decimal testValue2 = 2;

            // Act
            decimal errResult = API.Math.Add(testValue1, testValue2);

            // Assert
            Assert.NotEqual(0, errResult);
        }

        [Theory]
        [InlineData(2.5, 3.5, -1.0)]
        [InlineData(-4.5, -6.5, 2.0)]
        //[InlineData(-1.5, 2.5, 3.0)]
        public void Substract_ReturnsOkResult(decimal testValue1, decimal testValue2, decimal expectedResult)
        {
            // Act
            decimal okResult = API.Math.Substract(testValue1, testValue2);

            // Assert
            Assert.Equal(expectedResult, okResult);
        }

        [Fact]
        public void Substract_ReturnsErrResult()
        {
            // Arrange
            decimal testValue1 = 1;
            decimal testValue2 = 2;

            // Act
            decimal errResult = API.Math.Substract(testValue1, testValue2);

            // Assert
            Assert.NotEqual(1, errResult);
        }

        [Fact]
        public void Multiply_ResultTwo_ReturnsOkResult()
        {
            // Arrange
            decimal testValue1 = 1;
            decimal testValue2 = 2;

            // Act
            decimal okResult = API.Math.Multiply(testValue2, testValue1);

            // Assert
            Assert.Equal(2, okResult);
        }

        [Fact]
        public void Divide_ResultMiddle_ReturnsOkResult()
        {
            // Arrange
            decimal testValue1 = 1;
            decimal testValue2 = 2;

            // Act
            decimal okResult = API.Math.Divide(testValue1, testValue2);

            // Assert
            Assert.Equal((double)0.5, (double)okResult);
        }
    }
}
