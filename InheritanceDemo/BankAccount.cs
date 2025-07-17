using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public sealed class BankAccount
    {
        private double balance;

        public void Deposit(double amount)
        {
            balance = balance + amount;
        }

        public void Withdrawn(double amount)
        {
            if (amount <= balance)
                balance = balance - amount;
            else
                Console.WriteLine("Insufficient funds.");
        }

        public double GetBalance()
        {
            return balance;
        }

    }

    public class SBI : BankAccount
    {

    }
}
