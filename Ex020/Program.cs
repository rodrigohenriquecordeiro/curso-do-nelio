using System;

namespace Ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados do primeiro funcionáro:");
            Funcionario f1 = new Funcionario();
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: R$");
            f1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionáro:");
            Funcionario f2 = new Funcionario();
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: R$");
            f2.Salario = double.Parse(Console.ReadLine());

            double salarioMedio = (f1.Salario + f2.Salario) / 2;
            Console.WriteLine($"Salário médio = {salarioMedio:F2}");

            Console.ReadLine();
        }
    }
}
