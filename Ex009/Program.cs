using System;

namespace Ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1º número: "); int n1 = int.Parse(Console.ReadLine());
            Console.Write("2º número: "); int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (n1 % n2 == 0)
                Console.WriteLine("São Multiplos");
            else if (n2 % n1 == 0)
                Console.WriteLine("São Multiplos");
            else
                Console.WriteLine("Não são Multiplos");

            Console.ReadLine();
        }
    }
}
