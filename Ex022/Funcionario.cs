using System;
using System.Collections.Generic;
using System.Text;

namespace Ex004
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public override string ToString()
        {
            return Nome + ", $ " + SalarioLiquido().ToString("F2"); 
        }

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public double AumentarSalario(double porcentagem)
        {
            return SalarioBruto *= porcentagem / 100 + 1;
        }

    }
}
