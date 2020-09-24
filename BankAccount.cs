using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount()
        {
        }

        private double balance = 0;

        //Encapsulation
        public void Deposit(double amount)
        {
            balance = amount;
        }

        public string GetBalance()
        {
            return $"${balance}";
        }
    }
}
