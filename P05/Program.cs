using System;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            int numeros; int dentro = 0; int fora = 0;

            Console.WriteLine();
            for (int i = 1; i <= quantidade; i++)
            {
                Console.Write($"Digite o {i}º número: ");
                numeros = Convert.ToInt32(Console.ReadLine());

                if (numeros > 10 && numeros < 20) dentro++;
                else fora++;
            }
            Console.WriteLine($"\nIn: {dentro}.");
            Console.WriteLine($"Out: {fora}.");
        }
    }
}
