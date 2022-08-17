using System;

namespace Ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Digite o 1º número: "); int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Digite o 2º número: "); int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nSOMA = {n1 + n2}");

            Console.ReadLine();
        }
    }
}
