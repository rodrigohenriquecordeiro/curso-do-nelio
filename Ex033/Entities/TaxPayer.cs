namespace Ex033.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnuelIncome { get; set; }

        protected TaxPayer(string name, double anuelIncome)
        {
            Name = name;
            AnuelIncome = anuelIncome;
        }

        public abstract double Tax();
    }
}
