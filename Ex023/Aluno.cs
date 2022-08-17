using System;
using System.Collections.Generic;
using System.Text;

namespace Ex005
{
    class Aluno
    {
        public string Nome;
        public double T1, T2, T3;

        public double NotaFinal()
        {
            return ((T1 / 30) + (T2 / 35) + (T3 / 35)) / 3 * 100;
        }

        public bool Aprovacao()
        {
            if (NotaFinal() >= 60)
            {
                Console.WriteLine("APROVADO");
                return true;
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTAM {60 - NotaFinal():F2} PONTOS");
                return false;
            }
        }
    }
}
