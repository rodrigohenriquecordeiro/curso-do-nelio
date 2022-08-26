namespace Ex033.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anuelIncome, int numberOfEmployees) : base(name, anuelIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees > 10)
                return AnuelIncome * 0.14;
            else
                return AnuelIncome * 0.16;
        }
    }
}
