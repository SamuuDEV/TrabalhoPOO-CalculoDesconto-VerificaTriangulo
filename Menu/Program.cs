// See https://aka.ms/new-console-template for more information


using System;

class Program
{
    static void Main()
    {
        int opcao;
        do
        {
            Console.WriteLine("\n--- Menu de Opções ---");
            Console.WriteLine("0) Sair");
            Console.WriteLine("1) Calcular Desconto");
            Console.WriteLine("2) Verificar Triângulo");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 0:
                    Console.WriteLine("Saindo do programa...");
                    break;

                case 1:
                    ExecutarCalculoDesconto();
                    break;

                case 2:
                    ExecutarVerificacaoTriangulo();
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

        } while (opcao != 0);
    }

    static void ExecutarCalculoDesconto()
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

    static void ExecutarVerificacaoTriangulo()
    {
        // Solicita os três lados do triângulo
        Console.Write("Digite o primeiro lado do triângulo: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo lado do triângulo: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o terceiro lado do triângulo: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Verifica se os lados podem formar um triângulo
        if (VerificaTriangulo.PodeFormarTriangulo(a, b, c))
        {
            Console.WriteLine("Os valores informados podem formar um triângulo.");
            Console.WriteLine("Tipo de Triângulo: " + VerificaTriangulo.DeterminarTipoTriangulo(a, b, c));
        }
        else
        {
            Console.WriteLine("Os valores informados NÃO podem formar um triângulo.");
        }
    }
}

public class CalculaDesconto
{
    private decimal valorAtual;
    private decimal percentualDesconto;

    public CalculaDesconto(decimal valorAtual, decimal percentualDesconto)
    {
        this.valorAtual = valorAtual;
        this.percentualDesconto = percentualDesconto;
    }

    public decimal CalcularValorDesconto()
    {
        return (percentualDesconto / 100) * valorAtual;
    }

    public decimal CalcularValorFinal()
    {
        return valorAtual - CalcularValorDesconto();
    }

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
}

public class VerificaTriangulo
{
    public static bool PodeFormarTriangulo(double a, double b, double c)
    {
        return (a + b > c) && (a + c > b) && (b + c > a);
    }

    public static string DeterminarTipoTriangulo(double a, double b, double c)
    {
        if (a == b && b == c)
        {
            return "Equilátero";
        }
        else if (a == b || a == c || b == c)
        {
            return "Isósceles";
        }
        else
        {
            return "Escaleno";
        }
    }
}
