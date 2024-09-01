namespace VerificaTrianguloTest
{


    [TestClass]
    public class VerificaTrianguloTests
    {
        [TestMethod]
        public void PodeFormarTriangulo_ValoresValidos_DeveRetornarTrue() //Valores válidos para o triângulo 
        {
            // Cenário
            double a = 5;
            double b = 2;
            double c = 5;

            // Ação
            bool resultado = VerificaTriangulo.PodeFormarTriangulo(a, b, c);

            // Verificação
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void PodeFormarTriangulo_ValoresInvalidos_DeveRetornarFalse() //Valores inválidos para o triângulo 
        {
            // Cenário
            double a = 1;
            double b = 5;
            double c = 3;

            // Ação
            bool resultado = VerificaTriangulo.PodeFormarTriangulo(a, b, c);

            // Verificação
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void DeterminarTipoTriangulo_Equilatero_DeveRetornarEquilatero() //Verificação equilátero, todos os lados iguais
        {
            // Cenário
            double a = 3;
            double b = 3;
            double c = 3;

            // Ação
            string resultado = VerificaTriangulo.DeterminarTipoTriangulo(a, b, c); 

            // Verificação
            Assert.AreEqual("Equilátero", resultado);
        }

        [TestMethod]
        public void DeterminarTipoTriangulo_Isosceles_DeveRetornarIsosceles() //Verificação isosceles, dois lados iguais
        {
            // Cenário
            double a = 3;
            double b = 3;
            double c = 5;

            // Ação
            string resultado = VerificaTriangulo.DeterminarTipoTriangulo(a, b, c);

            // Verificação
            Assert.AreEqual("Isósceles", resultado);
        }

        [TestMethod]
        public void DeterminarTipoTriangulo_Escaleno_DeveRetornarEscaleno()  //Verificação escaleno, todos os lados diferentes
        {
            // Cenário
            double a = 3;
            double b = 4;
            double c = 5;

            // Ação
            string resultado = VerificaTriangulo.DeterminarTipoTriangulo(a, b, c);

            // Verificação
            Assert.AreEqual("Escaleno", resultado);
        }
    }




}