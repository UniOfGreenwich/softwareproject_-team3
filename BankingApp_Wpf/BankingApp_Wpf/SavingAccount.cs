using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp_Wpf
{
    public class SavingsAccount : Account
    {
        // Constructor
        public SavingsAccount(int accountNumber, string firstName, string lastName, double balance)
            : base(accountNumber, firstName, lastName){
        }

        // Implement abstract methods
        public override void Deposit(double amount)
        {
            // Implement deposit logic
            Balance += amount;
        }

        public override void Withdraw(double amount)
        {
            // Implement withdrawal logic
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
