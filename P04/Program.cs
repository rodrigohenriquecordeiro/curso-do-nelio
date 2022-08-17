using System;
using System.Threading;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = 2002; int senhaTentativa = 0;

            while (true)
            {
                Console.Write("Digite sua senha: ");
                senhaTentativa = Convert.ToInt32(Console.ReadLine());
                if (senhaTentativa != senha)
                {
                    Console.WriteLine("Senha errada");
                    Thread.Sleep(2000); Console.Clear();
                }
                else
                {
                    Thread.Sleep(2000); Console.Clear();
                    Console.WriteLine("Acesso Permitido");
                    break;
                }
            }
        }
    }
}
