using System;

namespace Ex008
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Salário: R$ "); double salario = double.Parse(Console.ReadLine());

            if (salario <= 2000)        // Isento
                Console.WriteLine("ISENTO");
            else if (salario <= 3000)   // 8%
                Console.WriteLine($"R$ {((salario - 2000) * 0.08):N2}");
            else if (salario <= 4500)   // 18%
                Console.WriteLine($"R$ {(79.99 + ((salario - 3000.01) * 0.18)):N2}");
            else                        // 28%
                Console.WriteLine($"R$ {(79.99 + 269.99 + ((salario - 4500.01) * 0.28)):N2}");

            Console.ReadLine();
        }
    }
}
