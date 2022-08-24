using Ex032.Entites;
using System;
using System.Collections.Generic;

namespace Ex032
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: "); int num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? "); char type = char.Parse(Console.ReadLine());
                Console.Write("Name: "); string name = Console.ReadLine();
                Console.Write("Price: "); double price = double.Parse(Console.ReadLine());
                if (type == 'i')
                {
                    Console.Write("Customs fee: "); double customsFee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (type == 'u')
                {
                    Console.Write("Manufacture date: "); DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                    list.Add(new Product(name, price));
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (var item in list)
                Console.Write($"{item.PriceTag()}");

            Console.ReadLine();
        }
    }
}
