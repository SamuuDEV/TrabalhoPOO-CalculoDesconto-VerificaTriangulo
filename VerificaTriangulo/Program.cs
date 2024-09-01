public class VerificaTriangulo
{
    static void Main()
    {
        // Solicita os três lados do triângulo
        Console.Write("Digite o primeiro lado do triângulo: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo lado do triângulo: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o terceiro lado do triângulo: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Verifica se os lados podem formar um triângulo
        if (PodeFormarTriangulo(a, b, c))
        {
            Console.WriteLine("Os valores informados podem formar um triângulo.");
            Console.WriteLine("Tipo de Triângulo: " + DeterminarTipoTriangulo(a, b, c));
        }
        else
        {
            Console.WriteLine("Os valores informados NÃO podem formar um triângulo.");
        }
    }

    public static bool PodeFormarTriangulo(double a, double b, double c)
    {
        // Condições do triângulo: Para que 3 números formem um triângulo
        // A soma de dois lados deverá ser maior que o valor do terceiro em todas as ordens possíveis
        return (a + b > c) && (a + c > b) && (b + c > a);
    }

    public static string DeterminarTipoTriangulo(double a, double b, double c)
    {
        // Triângulo equilátero: triângulo que possui todos os lados com medidas iguais.
        if (a == b && b == c)
        {
            return "Equilátero";
        }
        // Triângulo isósceles: triângulo que possui dois lados com medidas iguais.
        else if (a == b || a == c || b == c)
        {
            return "Isósceles";
        }
        // Triângulo escaleno: triângulo que possui todos os lados com medidas diferentes.
        else
        {
            return "Escaleno";
        }
    }
}
