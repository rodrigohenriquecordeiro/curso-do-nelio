using System;

namespace Ex005
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Console.Write("Nome do aluno: "); aluno.Nome = Console.ReadLine();
            Console.WriteLine($"Digite as três notas de {aluno.Nome}: ");
            aluno.T1 = double.Parse(Console.ReadLine());
            aluno.T2 = double.Parse(Console.ReadLine());
            aluno.T3 = double.Parse(Console.ReadLine());

            Console.WriteLine($"NOTA FINAL = {aluno.NotaFinal():F2}");

            aluno.Aprovacao();

            Console.ReadLine();
        }
    }
}
