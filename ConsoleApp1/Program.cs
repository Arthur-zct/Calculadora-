namespace Calculadora;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Calculadora Simples \n");
        Console.WriteLine("Digite o primeiro número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        //Selecionar o tipo da operação.
        Console.WriteLine("Selecione a operação:");
        Console.WriteLine("1 - Soma (+)");
        Console.WriteLine("2 - Subtração (-)");
        Console.WriteLine("3 - Multiplicação (*)");
        Console.WriteLine("4 - Divisão (/)");
        int operacao = Convert.ToInt32(Console.ReadLine());

        //Condições
        double result = 0;
        if (operacao == 1)
        {
            result = num1 + num2;
        }
        else if (operacao == 2)
        {
            result = num1 - num2;
        }
        else if (operacao == 3)
        {
            result = num1 * num2;
        }
        else if (operacao == 4)
        {
            if (num2 != 0)
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Erro: Divisão por zero não é permitida.");
                return;
            }
        }
        else
        {
            Console.WriteLine("Operação inválida.");
            return;
        }
        Console.WriteLine($"O resultado é: {result}");
    }
}