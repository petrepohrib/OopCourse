using System;

namespace BankAccount
{
    public class BankAccount
    {
        // A bank account has an owner, balance, interest and number account.
        // Can perform: Deposit,  Withdrawl and Display information about the bank account.
        public string Owner { get; set; }
        public decimal Balance { get; set; }
        public decimal Interest { get; set; }
        public string AccountNumber { get; set; }

        public BankAccount()
        {
            Owner = string.Empty;
            Balance = 0m;
            Interest = 0m;
            AccountNumber = string.Empty;
        }

        public BankAccount(string owner, decimal sold, decimal interest, string accountNumber)
        {
            Owner = owner;
            Balance = sold;
            Interest = interest;
            AccountNumber = accountNumber;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0m)
            {
                throw new ApplicationException("Invalid deposit amount");
            }

            Balance += amount;
            Console.WriteLine("The amount you deposited is: " + amount);
        }

        public bool Withdrawal(decimal withdrawalAmount)
        {
            if (withdrawalAmount > Balance)
            {
                throw new ApplicationException("Insufficient funds!");
            }
            else if (withdrawalAmount <= 0m)
            {
                throw new ApplicationException("Invalid withdrawal amount!");
            }

            Balance -= withdrawalAmount;

            return true;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("-------------Bank account details are---------------");
            Console.WriteLine("Owner: " + Owner);
            Console.WriteLine("Current balance: " + Balance);
            Console.WriteLine("Interest: " + Interest);
            Console.WriteLine("Account number: " + AccountNumber);
            Console.WriteLine();
        }
    }
}
