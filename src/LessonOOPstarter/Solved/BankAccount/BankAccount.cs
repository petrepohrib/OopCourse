using System;

namespace BankAccount
{
    public class BankAccount
    {
        // A bank account has an owner, balance, interest and number account.
        // Can perform: Deposit,  Withdrawl and Display information about the bank account.
        public string owner;
        public decimal balance;
        public decimal interest;
        public string accountNumber;

        public BankAccount()
        {
            this.owner = string.Empty;
            this.balance = 0m;
            this.interest = 0m;
            this.accountNumber = string.Empty;
        }

        public BankAccount(string owner, decimal balance, decimal interest, string accountNumber)
        {
            this.owner = owner;
            this.balance = balance;
            this.interest = interest;
            this.accountNumber = accountNumber;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0m)
            {
                throw new ApplicationException("Invalid deposit amount");
            }

            this.balance += amount;
            Console.WriteLine("The amount you deposited is: " + amount);
        }

        public void Withdrawal(decimal withdrawalAmount)
        {
            if (withdrawalAmount > this.balance)
            {
                throw new ApplicationException("Insufficient funds!");
            }
            else if (withdrawalAmount <= 0m)
            {
                throw new ApplicationException("Invalid withdrawal amount!");
            }

            this.balance -= withdrawalAmount;
            Console.WriteLine("The withdrawal action was successful. Your actual balanace is:" + this.balance);
        }

        public void DisplayDetails()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            var output = $@"-------------Bank account details are---------------
                        Owner: {this.owner}
                        Current balance: {this.balance}
                        Interest: {this.interest}
                        Account number: {this.accountNumber}";
            return output;

        }
    }
}
