using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Valor do Raio do Círculo: ");
            int raio = Convert.ToInt32(Console.ReadLine());
            double area = 3.14159 * (raio * raio);

            Console.WriteLine($"Àrea: {area:N4}");
        }
    }
}
