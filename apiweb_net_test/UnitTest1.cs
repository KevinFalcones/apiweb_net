using System;
using Xunit;
using API;

namespace apiweb_net_test
{
    public class MathTest
    {
        /*
        Arrange [Organizar] : aquí es donde normalmente prepararía todo para la prueba, en otras palabras, prepare la escena para la prueba (creando los objetos y configurándolos según sea necesario)

        Act [Actuar] : aquí es donde se ejecuta el método que estamos probando.

        Assert [Afirmar] : esta es la parte final de la prueba en la que comparamos lo que esperamos que suceda con el resultado real de la ejecución del método de prueba.
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
            var testValue1 = 1;
            var testValue2 = 2;

            // Act
            var errResult = API.Math.Add(testValue1, testValue2);

            // Assert
            Assert.NotEqual(0, errResult);
        }

        [Theory]
        [InlineData(2, 3, -1)]
        [InlineData(-4, -6, 2)]
        //[InlineData(-1, 2, 3)]
        public void Substract_ReturnsOkResult(int testValue1, int testValue2, int expectedResult)
        {
            // Act
            var okResult = API.Math.Substract(testValue1, testValue2);

            // Assert
            Assert.Equal(expectedResult, okResult);
        }

        [Fact]
        public void Substract_ReturnsErrResult()
        {
            // Arrange
            var testValue1 = 1;
            var testValue2 = 2;

            // Act
            var errResult = API.Math.Substract(testValue1, testValue2);

            // Assert
            Assert.NotEqual(1, errResult);
        }

        [Fact]
        public void Multiply_ResultTwo_ReturnsOkResult()
        {
            // Arrange
            var testValue1 = 1;
            var testValue2 = 2;

            // Act
            var okResult = API.Math.Multiply(testValue2, testValue1);

            // Assert
            Assert.Equal(2, okResult);
        }

        [Fact]
        public void Divide_ResultMiddle_ReturnsOkResult()
        {
            // Arrange
            var testValue1 = 1;
            var testValue2 = 2;

            // Act
            var okResult = API.Math.Divide(testValue1, testValue2);

            // Assert
            Assert.Equal((double)0.5, (double)okResult);
        }
    }
}
