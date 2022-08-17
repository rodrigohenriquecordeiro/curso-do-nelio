using System;

namespace Ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha inválida");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");

            Console.ReadLine();
        }
    }
}
