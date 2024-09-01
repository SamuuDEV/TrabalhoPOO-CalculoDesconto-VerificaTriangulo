namespace VerificaTrianguloTest
{


    [TestClass]
    public class VerificaTrianguloTests
    {
        [TestMethod]
        public void PodeFormarTriangulo_ValoresValidos_DeveRetornarTrue() //Valores v�lidos para o tri�ngulo 
        {
            // Cen�rio
            double a = 5;
            double b = 2;
            double c = 5;

            // A��o
            bool resultado = VerificaTriangulo.PodeFormarTriangulo(a, b, c);

            // Verifica��o
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void PodeFormarTriangulo_ValoresInvalidos_DeveRetornarFalse() //Valores inv�lidos para o tri�ngulo 
        {
            // Cen�rio
            double a = 1;
            double b = 5;
            double c = 3;

            // A��o
            bool resultado = VerificaTriangulo.PodeFormarTriangulo(a, b, c);

            // Verifica��o
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void DeterminarTipoTriangulo_Equilatero_DeveRetornarEquilatero() //Verifica��o equil�tero, todos os lados iguais
        {
            // Cen�rio
            double a = 3;
            double b = 3;
            double c = 3;

            // A��o
            string resultado = VerificaTriangulo.DeterminarTipoTriangulo(a, b, c); 

            // Verifica��o
            Assert.AreEqual("Equil�tero", resultado);
        }

        [TestMethod]
        public void DeterminarTipoTriangulo_Isosceles_DeveRetornarIsosceles() //Verifica��o isosceles, dois lados iguais
        {
            // Cen�rio
            double a = 3;
            double b = 3;
            double c = 5;

            // A��o
            string resultado = VerificaTriangulo.DeterminarTipoTriangulo(a, b, c);

            // Verifica��o
            Assert.AreEqual("Is�sceles", resultado);
        }

        [TestMethod]
        public void DeterminarTipoTriangulo_Escaleno_DeveRetornarEscaleno()  //Verifica��o escaleno, todos os lados diferentes
        {
            // Cen�rio
            double a = 3;
            double b = 4;
            double c = 5;

            // A��o
            string resultado = VerificaTriangulo.DeterminarTipoTriangulo(a, b, c);

            // Verifica��o
            Assert.AreEqual("Escaleno", resultado);
        }
    }




}