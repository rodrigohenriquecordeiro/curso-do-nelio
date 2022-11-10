using System;
using System.IO;
using Ex041.Entities;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Ex041
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\rodri\OneDrive\Documentos\TI\Back-End\CSharp\Udemy\Exercicios\Ex041\in.txt";
            var CI = CultureInfo.InvariantCulture;
            List<Funcionarios> func = new List<Funcionarios>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] dados = sr.ReadLine().Split(',');
                    string Nome = dados[0].ToUpper();
                    string Email = dados[1].ToUpper();
                    double Salario = double.Parse(dados[2], CI);
                    func.Add(new Funcionarios(Nome, Email, Salario));
                }
            }

            Console.WriteLine("Lista de Funcionários");
            foreach (var item in func)
            {
                Console.WriteLine($"{item.Nome}, {item.Email}, {item.Salario.ToString("F2")}");
            }

            var salarioMaior = func.Where(f => f.Salario > 3000.00).Select(f => f.Nome).ToList();
            Console.WriteLine($"\nMaiores Salários");
            foreach (var item in salarioMaior)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
