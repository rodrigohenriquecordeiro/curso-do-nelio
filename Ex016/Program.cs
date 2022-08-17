using System;

namespace Ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[1] - Alcool \n[2] - Gasolina \n[3] - Diesel \n[4] - Fechar");
            Console.Write("\nDigite sua escolha: "); int escolha = int.Parse(Console.ReadLine());

            int alcool = 0; int gasolina = 0; int diesel = 0;

            while (escolha != 4)
            {
                if (escolha == 1) alcool++;
                else if (escolha == 2) gasolina++;
                else diesel++;

                Console.Write("Digite sua escolha: "); escolha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nMUITO OBRIGADO");
            Console.WriteLine($"Alcool: {alcool} \nGasolina: {gasolina} \nDiesel: {diesel}");

            Console.ReadLine();
        }
    }
}
