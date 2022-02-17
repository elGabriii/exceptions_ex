using System;
using System.Collections.Generic;
using System.Text;

namespace exception_ex.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void deposit(double amount)
        {
            Balance += amount;
        }
        public void withdraw(double amount)
        {
            Balance -= amount;
        }
    }
}

