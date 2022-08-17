using System;

namespace Ex004
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            Console.Write("Nome: "); f.Nome = Console.ReadLine();
            Console.Write("Salário bruto: "); f.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: "); f.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine($"\n{f}\n");

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            f.AumentarSalario(double.Parse(Console.ReadLine()));

            Console.WriteLine($"\nDados atualizados: {f}");

            Console.ReadLine();
        }
    }
}
