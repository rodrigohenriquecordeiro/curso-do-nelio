using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosDeFixacao08
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Funcionario(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void Aumento(int id, double porcentagem)
        {
            Id = id;
            Salary *= porcentagem / 100 + 1;
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Salary:C2}.";
        }
    }
}
