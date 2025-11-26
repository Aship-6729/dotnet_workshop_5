using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class BankAccount
    {
        private int accountNumber;
        private double balance;

        public BankAccount(int accountNumber, double balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }


        public int GetAccountNumber()
        {
            return this.accountNumber;
        }


        public double GetBalance()
        {
            return this.balance;
        }

        private double SetBalance(int amount)
        {
            if (amount > 0)
            {
                this.balance = amount;
                return this.balance;
            }

            return 1;

        }


        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                this.balance += amount;
      
            }
            
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && this.balance >= amount)
            {
                this.balance -= amount;
            }
            
        }

    }
}
