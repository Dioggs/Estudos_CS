using System;
using System.Drawing;
using System.Globalization;

public class FirstClass
{
    private static void Main(string[] args)
    {
        //Setup
        int num_tentativas = 0;

        //Resposta
        Random rannum = new Random();
        int resposta = rannum.Next(1, 20);

        //Tentativa
        Console.WriteLine("Ola! bem vindo ao jogo!");
        int num = 0;

        while (num != resposta)
        {
            Console.Write("diga um numero entre 1 e 20: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num < resposta)
            {
                Console.WriteLine($"{num} é muito baixo!");
            }

            else if (num > resposta)
            {
                Console.WriteLine($"{num} é muito alto!");
            }

            num_tentativas++;
        }

        Console.WriteLine($"Parabens! você conseguiu em {num_tentativas} tentativas! bom trabalho");

    }   
        
}
