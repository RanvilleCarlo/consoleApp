using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ConsoleApp1.src.oops.encapsulation
{
    public class BankAccount
    {
        private decimal balance;
        public BankAccount(decimal balance)
        {
            Deposit(balance);
        }
        
        public Decimal GetBalance()
        {
            return balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "The deposit amount cannot be negative");
            }
            this.balance += amount;

        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "The withdrawal amount cannot be negative");
            }
            if(amount > balance)
            {
                throw new InvalidOperationException("Insufficient funds");
            }
            this.balance -= amount;
        }
        
    }
}