using System;

namespace ExerciciosDeFixacao10.Entities
{
    public class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        //Construtor Padrão
        public HourContract()
        {
            
        }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
