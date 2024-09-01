using System;

class CalculaDesconto
{
    private decimal valorAtual;
    private decimal percentualDesconto;

    // Construtor para inicializar os valores
    public CalculaDesconto(decimal valorAtual, decimal percentualDesconto)
    {
        this.valorAtual = valorAtual;
        this.percentualDesconto = percentualDesconto;
    }

    // Método para calcular o valor do desconto
    public decimal CalcularValorDesconto()
    {
        return (percentualDesconto / 100) * valorAtual;
    }

    // Método para calcular o valor final da mercadoria
    public decimal CalcularValorFinal()
    {
        return valorAtual - CalcularValorDesconto();
    }

    // Método para exibir as informações
    public void ExibirInformacoes()
    {
        decimal valorDesconto = CalcularValorDesconto();
        decimal valorFinal = CalcularValorFinal();

        Console.WriteLine("\n--- Informações da Compra ---");
        Console.WriteLine("Valor atual da mercadoria: R$ " + valorAtual);
        Console.WriteLine("Percentual de desconto: " + percentualDesconto + "%");
        Console.WriteLine("Valor do desconto: R$ " + valorDesconto);
        Console.WriteLine("Valor final da mercadoria: R$ " + valorFinal);
    }

    public static void Main()
    {
        // Solicita o valor atual da mercadoria
        Console.Write("Digite o valor atual da mercadoria: R$ ");
        decimal valorAtual = Convert.ToDecimal(Console.ReadLine());

        // Solicita o percentual de desconto
        Console.Write("Digite o percentual de desconto: ");
        decimal percentualDesconto = Convert.ToDecimal(Console.ReadLine());

        // Instancia a classe CalculaDesconto
        CalculaDesconto calculo = new CalculaDesconto(valorAtual, percentualDesconto);

        // Exibe as informações
        calculo.ExibirInformacoes();
    }
}
