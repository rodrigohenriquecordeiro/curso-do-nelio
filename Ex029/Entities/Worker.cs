using ExerciciosDeFixacao10.Entities.Enums;
using System.Collections.Generic;

namespace ExerciciosDeFixacao10.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {
            
        }

        // Não é usual passar uma lista instanciada no Construtor de um Objeto, a lista deve começar vazia
        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddContract(HourContract contract)
        {
            //Adiciona na lista o contrato
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            //Remove da lista o contrato
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                    sum += contract.TotalValue();
            }
            return sum;
        }
    }
}
