using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosDeFixacao07
{
    class Pensionato
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        public override string ToString()
        {
            return $"{Quarto}: {Nome}, {Email}";
        }
    }
}
