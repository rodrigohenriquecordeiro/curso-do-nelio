using System;

namespace Ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: "); int num = int.Parse(Console.ReadLine());

            if (num < 0) Console.WriteLine("NEGATIVO");
            else Console.WriteLine("NÃO NEGATIVO");

            Console.ReadLine();
        }
    }
}
