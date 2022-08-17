using System;
using System.Collections.Generic;

namespace ExerciciosDeFixacao08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? "); int empregadosRegistrados = int.Parse(Console.ReadLine());

            int id; string name; double salary;
            List<Funcionario> lista = new List<Funcionario>();

            for (int i = 0; i < empregadosRegistrados; i++)
            {
                Console.WriteLine($"\nEmployee #{i + 1}");
                Console.Write("Id: "); id = int.Parse(Console.ReadLine());
                Console.Write("Name: "); name = Console.ReadLine();
                Console.Write("Salary: "); salary = double.Parse(Console.ReadLine());
                lista.Add(new Funcionario(id, name, salary));
            }

            Console.Write("\nEnter the employee id that will have salary increase: "); int funcionarioEscolhido = int.Parse(Console.ReadLine());

            Funcionario s1 = lista.Find(x => funcionarioEscolhido == x.Id);
            if (s1 != null)
            {
                Console.Write("Enter the percentage: "); double porcentagemDoAumento = double.Parse(Console.ReadLine());
                s1.Aumento(funcionarioEscolhido, porcentagemDoAumento);
            }
            else
                Console.WriteLine("This id does not exist!");

            Console.WriteLine("\nUpdate list of employees:\n");
            foreach (var item in lista)
                Console.WriteLine(item);

            Console.ReadLine();
        }
    }
}
