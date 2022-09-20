using System;
using System.Collections.Generic;
using System.Text;

namespace Ex038.Services
{
    class PaypalService : IOnlinePaymentService
    {
        public double paymentFee(double amount)
        {
            return amount * 0.02;
        }

        public double interest(double amount, int months)
        {
            for (int i = 1; i <= months; i++)
            {
                amount *= i;
            }
            return amount;
        }
    }
}
