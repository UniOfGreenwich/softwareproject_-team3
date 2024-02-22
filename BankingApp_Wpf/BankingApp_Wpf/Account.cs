using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp_Wpf
{
    /// <summary>
    /// Represents an abstract class for various types of accounts in a banking system.
    /// </summary>
    public abstract class Account
    {
        /// <summary>
        /// Gets or sets the account number.
        /// </summary>
        public int AccountNumber { get; set; }

        /// <summary>
        /// Gets or sets the first name of the account holder.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name of the account holder.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the balance of the account.
        /// </summary>
        protected double Balance { get; set; }

        public abstract double GetBalance();

        /// <summary>
        /// Creates a new account with the specified details.
        /// </summary>
        /// <param name="accountNumber">The account number.</param>
        /// <param name="firstName">The first name of the account holder.</param>
        /// <param name="lastName">The last name of the account holder.</param>
        public Account(int accountNumber, string firstName, string lastName)
        {
            AccountNumber = accountNumber;
            FirstName = firstName;
            LastName = lastName;
            Balance = 0;
        }

        /// <summary>
        /// Deposits the specified amount into the account.
        /// </summary>
        /// <param name="amount">The amount to be deposited.</param>
        public abstract void Deposit(double amount);

        /// <summary>
        /// Withdraws the specified amount from the account.
        /// </summary>
        /// <param name="amount">The amount to be withdrawn.</param>
        public abstract void Withdraw(double amount);

        /// <summary>
        /// Modifies the account details.
        /// </summary>
        /// <param name="firstName">The new first name of the account holder.</param>
        /// <param name="lastName">The new last name of the account holder.</param>
        public void ModifyAccount(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

}
