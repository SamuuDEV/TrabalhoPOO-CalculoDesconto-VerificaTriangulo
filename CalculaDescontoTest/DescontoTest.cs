namespace CalculaDescontoTest
{
    [TestClass]
    public class MercadoriaTest
    {
        [TestMethod]
        public void DescontoTest()
        {
            //cenario
            decimal valorAtual = 100;
            decimal percentualDesconto = 10;
            decimal valorDesconto;
            decimal valorFinal;

            //acao
            valorDesconto = (percentualDesconto / 100) * valorAtual; //Calculo do valor referente ao percentual de desconto
            valorFinal = valorAtual - valorDesconto;


            //verificacao
            Assert.AreEqual(90, valorFinal);

        }
    }
}