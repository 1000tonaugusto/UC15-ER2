using IMCNuttrivita;
namespace TestXUnitNuttrivita
{
    public class UnitTest1
    {
        // Teste do metodo de calculo de imc
        [Theory]
        [InlineData(29.00, 1.65, 0, 18.4)]
        [InlineData(65.00, 1.65, 0, 18.4)]
        [InlineData(35.00, 1.65, 0, 18.4)]

        public void TesteCalculoIMC(double nPeso, 
                                    double nTamanho, 
                                    double nResultadoMinimo, 
                                    double nResultadoMaximo)
        {
            // Act
            var resultado = Imc.CalcularIMC(nPeso, nTamanho);

            // Assert
            //Assert
            Assert.InRange(resultado, nResultadoMinimo, nResultadoMaximo);
        }

        // Teste do metodo de mostrar o resultado do calculo de icm
        [Theory]
        [InlineData(20.0, 0, 18.4)]
        [InlineData(10.0, 0, 18.4)]
        [InlineData(25.0, 18.5, 24.9)]

        public void TesteMostrarResultado(double resultado, 
                                          double nResultadoMinino, 
                                          double nResultadoMaximo)
        {
            Assert.InRange(resultado, nResultadoMinino, nResultadoMaximo);
        }
    }
}