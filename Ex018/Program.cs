using System;

namespace Ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: "); int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
