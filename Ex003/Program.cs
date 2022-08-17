using System;
using System.Collections.Generic;

namespace Ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A: "); int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B: "); int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("C: "); int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("D: "); int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\n{a * b - c * d}");

            Console.ReadLine();
        }
    }
}
