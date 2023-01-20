using System.Drawing;

public class program
{
    public static void Main()
    {
        Console.WriteLine("-------------------");
        Console.WriteLine("Calculadora Digital");
        Console.WriteLine("-------------------");

        //Operação
        Console.WriteLine("Gostaria de somar, substrair, multiplicar ou dividir?: ");
        string operação = Console.ReadLine();

        //Primeiro numero
        Console.WriteLine("Fornece um numero: ");
        int num1 = Convert.ToInt16(Console.ReadLine());

        //Segundo numero
        Console.WriteLine("Fornece outro numero: ");
        int num2 = Convert.ToInt16(Console.ReadLine());


        switch (operação)
        {
            case "somar":
                Console.WriteLine($"a soma entre {num1} e {num2} é {num1 + num2}");
                break;
            case "substrair":
                Console.WriteLine($"a substração entre {num1} e {num2} é {num1 - num2}");
                break;
            case "multiplicar":
                Console.WriteLine($"a multiplicação entre {num1} e {num2} é {num1 * num2}");
                break;
            case "dividir":
                Console.WriteLine($"a divisão entre {num1} e {num2} é {num1 / num2}");
                break;
            default:
                Console.WriteLine("isso não é uma operação válida");
                break;
        }
    }
}