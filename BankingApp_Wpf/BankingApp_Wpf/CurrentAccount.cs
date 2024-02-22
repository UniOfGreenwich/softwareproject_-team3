using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp_Wpf
{
    public class CurrentAccount : Account
    {
        // Constructor
        public CurrentAccount(int accountNumber, string firstName, string lastName, double balance)
            : base(accountNumber, firstName, lastName)
        {
        }

        // Implement abstract methods
        public override void Deposit(double amount)
        {
            // Implement deposit logic for current account
            Balance += amount;
        }

        public override void Withdraw(double amount)
        {
            // Implement withdrawal logic for current account
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient funds for withdrawal.");
            }
        }

        public override double GetBalance()
        {
            return Balance;
        }

    }

}
