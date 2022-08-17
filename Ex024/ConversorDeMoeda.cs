using System;
using System.Collections.Generic;
using System.Text;

namespace Ex006
{
    class ConversorDeMoeda
    {
        public static double IOF = 1.06;

        public static double Dolar(double cotacao, double quantidade)
        {
            return cotacao * quantidade * IOF;
        }
    }
}
