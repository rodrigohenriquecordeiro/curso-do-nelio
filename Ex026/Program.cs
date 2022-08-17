using System;

namespace ExerciciosDeFixacao07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");

            int n = int.Parse(Console.ReadLine());
            Pensionato[] quartos = new Pensionato[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nAluguel #{i + 1}");
                Console.Write("Nome: "); string nome = Console.ReadLine();
                Console.Write("Email: "); string email = Console.ReadLine();
                Console.Write("Quarto: "); int quartoEscolhido = int.Parse(Console.ReadLine());

                quartos[i] = new Pensionato { Nome = nome, Email = email, Quarto = quartoEscolhido };
            }

            Console.WriteLine("\nQuartos ocupados: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(quartos[i]);
            }
            Console.ReadLine();
        }
    }
}
