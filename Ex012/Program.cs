using System;

namespace Ex007
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("X: "); double x = double.Parse(Console.ReadLine());
            Console.Write("Y: "); double y = double.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
                Console.WriteLine("Q1");
            else if (x < 0 && y > 0)
                Console.WriteLine("Q2");
            else if (x < 0 && y < 0)
                Console.WriteLine("Q3");
            else if (x > 0 && y < 0)
                Console.WriteLine("Q4");
            else
                Console.WriteLine("Origem");

            Console.ReadLine();
        }
    }
}
