using System;

namespace Ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o raio de um círculo: "); double raio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"A={3.14159 * Math.Pow(raio, 2):F4}");

            Console.ReadLine();
        }
    }
}
