using Xunit;
using operaciones;

namespace TestOperaciones
{
    public class UnitTests
    {
        // AAA (Arrange, Act, Assert)
        [Theory]
        [InlineData(2, 3, 5)] // Prueba de suma con datos fijos
        [InlineData(3, 3, 6)] // Prueba de suma con datos fijos
        [InlineData(4, 11, 15)] // Prueba de suma con datos fijos
        [InlineData(12, 55, 67)] // Prueba de suma con datos fijos
        [InlineData(4, 1, 5)] // Prueba de suma con datos fijos
        public void TestSuma(int a, int b, int resultadoEsperado)
        {
            // Arrange: Preparar los datos de entrada
            int resultadoReal;

            // Act: Invocar al método
            OperacionesBasicas operaciones = new OperacionesBasicas();
            resultadoReal = operaciones.Suma(a, b);

            // Assert: Verificar el resultado
            Assert.Equal(resultadoEsperado, resultadoReal);
        }

        // AAA (Arrange, Act, Assert)
        [Theory]
        [InlineData(2, 3, 6)] // Prueba de multiplicación con datos fijos
        [InlineData(3, 3, 9)] // Prueba de multiplicación con datos fijos
        [InlineData(4, 11, 44)] // Prueba de multiplicación con datos fijos
        [InlineData(12, 5, 60)] // Prueba de multiplicación con datos fijos
        [InlineData(4, 0, 0)] // Prueba de multiplicación por 0
        public void TestMultiplicacion(int a, int b, int resultadoEsperado)
        {
            // Arrange: Preparar los datos de entrada
            int resultadoReal;

            // Act: Invocar al método
            OperacionesBasicas operaciones = new OperacionesBasicas();
            resultadoReal = operaciones.Multiplicacion(a, b);

            // Assert: Verificar el resultado
            Assert.Equal(resultadoEsperado, resultadoReal);
        }
    }
}