using Ex035.Entities;
using Ex035.Entities.Exception;
using System;

namespace Ex035
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: "); int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: "); string holder = Console.ReadLine();
                Console.Write("Initial Balance: "); double balance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw Limit: "); double withdrawLimit = double.Parse(Console.ReadLine());
                Account account = new Account(number, holder, balance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: "); double amountForWithdraw = double.Parse(Console.ReadLine());
                account.WithDraw(amountForWithdraw);
            }
            catch (NotEnoughBalanceException e)
            {
                Console.WriteLine($"Withdraw error: {e.Message}");
            }
            catch (AmountExceedsException e)
            {
                Console.WriteLine($"Withdraw error: {e.Message}");
            }
        }
    }
}
