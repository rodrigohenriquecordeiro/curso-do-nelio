﻿using System.Globalization;

namespace Ex037.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax;  }
        }

        public override string ToString()
        {
            var CI = CultureInfo.InvariantCulture;

            return $"Basic Payment: {BasicPayment.ToString("F2", CI)} " +
                $"\nTax: {Tax.ToString("F2", CI)} " +
                $"\nTotal Payment: {TotalPayment.ToString("F2", CI)}";
        }
    }
}
