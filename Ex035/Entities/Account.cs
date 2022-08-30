﻿using Ex035.Entities.Exception;
using System;

namespace Ex035.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        { 
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if (amount > WithdrawLimit)
                throw new AmountExceedsException("The amount exceeds withdraw limit");
            if (Balance < amount)
                throw new NotEnoughBalanceException("Not enough balance");

            Balance -= amount;
            Console.WriteLine($"New Balance: {Balance:C2}");
        }
    }
}
