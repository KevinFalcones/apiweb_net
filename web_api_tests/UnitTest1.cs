using System;
using Xunit;
using API;
using Math = API.Math;

namespace web_api_tests
{
    public class MathControllerTest
    {
        private readonly Math _math;
        /*
        Arrange [Organizar] : aqu� es donde normalmente preparar�a todo para la prueba, en otras palabras, prepare la escena para la prueba (creando los objetos y configur�ndolos seg�n sea necesario)

        Act [Actuar] : aqu� es donde se ejecuta el m�todo que estamos probando.

        Assert [Afirmar] : esta es la parte final de la prueba en la que comparamos lo que esperamos que suceda con el resultado real de la ejecuci�n del m�todo de prueba.
        */
        public MathTest()
        {
            //_configuration = new IConfiguration();
            _math = new Math();
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-4, -6, -10)]
        [InlineData(-2, 2, 0)]
        public void Add_ReturnsOkResult(int testValue1, int testValue2, int expectedResult)
        {
            // Act
            var okResult = _math.Add(testValue1, testValue2);

            // Assert
            Assert.Equal(expectedResult, okResult);
        }
        [Fact]
        public void Add_ReturnsErrResult()
        {
            // Arrange
            int testValue1 = 1;
            int testValue2 = 2;

            // Act
            var errResult = _math.Add(testValue1, testValue2);

            // Assert
            Assert.Equal(0, errResult);
        }

        [Theory]
        [InlineData(2, 3, -1)]
        [InlineData(-4, -6, 2)]
        [InlineData(-1, 2, 3)]
        public void Substract_ReturnsOkResult(int testValue1, int testValue2, int expectedResult)
        {
            // Act
            var okResult = _math.Substract(testValue1, testValue2);

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
            var errResult = _math.Add(testValue1, testValue2);

            // Assert
            Assert.Equal(0, errResult);
        }
        [Fact]
        public void Multiply_ResultTwo_ReturnsOkResult()
        {
            // Arrange
            var testValue1 = 1;
            var testValue2 = 2;

            // Act
            var okResult = _math.Multiply(testValue2, testValue1);

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
            var okResult = _math.Divide(testValue1, testValue2);

            // Assert
            Assert.Equal(0.5, okResult);
        }
    }
}
