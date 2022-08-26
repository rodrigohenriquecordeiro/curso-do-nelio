namespace Ex033.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anuelIncome, double healthExpenditures) : base(name, anuelIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (AnuelIncome < 20000.00 && HealthExpenditures == 0)
                return AnuelIncome * 0.15;
            else if (AnuelIncome < 20000.00 && HealthExpenditures > 0)
                return AnuelIncome * 0.15 - HealthExpenditures / 2;
            else if (AnuelIncome > 20000.00 && HealthExpenditures == 0)
                return AnuelIncome * 0.25;
            else
                return AnuelIncome * 0.25 - HealthExpenditures / 2;
        }
    }
}
