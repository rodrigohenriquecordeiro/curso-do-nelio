using System;

namespace Ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: "); int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0) Console.WriteLine("PAR");
            else Console.WriteLine("ÍMPAR");

            Console.ReadLine();
        }
    }
}
