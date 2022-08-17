using System;

namespace Ex006
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A = "); double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("B = "); double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("C = "); double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\nTRIÂNGULO: {(a * c) / 2:F3}");
            Console.WriteLine($"CIRCULO: {Math.PI * Math.Pow(c, 2):F3}");
            Console.WriteLine($"TRAPÉZIO: {((a + b) / 2) * c:F3}");
            Console.WriteLine($"QUADRADO: {b * b:F3}");
            Console.WriteLine($"TRIÂNGULO: {a * b:F3}");

            Console.ReadLine();
        }
    }
}
