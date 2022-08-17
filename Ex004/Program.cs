using System;

namespace Ex004
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número do Funcionário: "); int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Horas trabalhadas: "); double horas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Valor por hora: "); double valorHora = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\nNÚMERO: {num}.");
            Console.WriteLine($"SALÁRIO: {horas * valorHora:C2}.");

            Console.ReadLine();
        }
    }
}
