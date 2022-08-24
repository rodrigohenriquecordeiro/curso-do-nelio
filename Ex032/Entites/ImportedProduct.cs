using System.Text;

namespace Ex032.Entites
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        { 
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name} {TotalPrice():N2} (Custom fee: {CustomsFee:N2})");
            return sb.ToString();
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}
