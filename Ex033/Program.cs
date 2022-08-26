using Ex033.Entities;
using System;
using System.Collections.Generic;

namespace Ex033
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: "); int numberOfTaxpayers = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberOfTaxpayers; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? "); char opcao = char.Parse(Console.ReadLine());
                Console.Write("Name: "); string name = Console.ReadLine();
                Console.Write("Anuel income: "); double anualIncome = double.Parse(Console.ReadLine());
                if (opcao == 'i')
                {
                    Console.Write("Health expenditures: "); double healthExpenditures = double.Parse(Console.ReadLine());
                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: "); int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberOfEmployees));
                }
                Console.WriteLine();
            }

            Console.WriteLine("TAXES PAID");
            double totalTaxPay = 0.0;
            foreach (TaxPayer item in list)
            {
                Console.WriteLine($"{item.Name}: {item.Tax():C2}");
                totalTaxPay += item.Tax();
            }
            Console.WriteLine($"\nTOTAL TAXES: {totalTaxPay:C2}");

            Console.ReadLine();
        }
    }
}
