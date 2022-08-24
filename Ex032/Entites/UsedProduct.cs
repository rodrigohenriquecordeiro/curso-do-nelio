using System;
using System.Text;

namespace Ex032.Entites
{
    class UsedProduct : Product
    {
        public DateTime manufactureDate { get; set; }

        public UsedProduct()
        { 
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            this.manufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name} (used) {Price:N2} (Manufacture Date: {manufactureDate.ToString("d")})");
            return sb.ToString();
        }
    }
}
