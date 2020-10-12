using System;

namespace BankAccount
{
    public static class Program
    {
        // Create an object with the name BankAccount. 
        // A bank account has an owner, balance, interest and number account.
        // Can perform: Deposit,  Withdrawl and Display information about the bank account.
        public static void Main(string[] args)
        {
            int n = GetIntFromConsole("Enter how many bank accounts you need..");
            BankAccount[] bankAccounts = new BankAccount[n];
            ReadBankAccounts(bankAccounts, n);
            DisplayBankAccounts(bankAccounts, n);
            AvarageInterest(bankAccounts, n);
            DepositeDoubleBalanceForOwnerBill(bankAccounts, n);
            WithdrawalHalfBalance(bankAccounts, n);
        }

        /// <summary>
        /// Write a C# program to read all details for the bank accounts.
        /// </summary>
        static void ReadBankAccounts(BankAccount[] bankAccounts, int n)
        {
            int i = 0;
            string owner, numberAccount;
            decimal interest, balance;

            while (i < n)
            {
                owner = GetStringFromConsole("Owner = ");
                numberAccount = GetStringFromConsole("Number account = ");
                interest = GetDecimalFromConsole("Interest = ");
                balance = GetDecimalFromConsole("Balance = ");
                BankAccount bankAccount = new BankAccount(owner, balance, interest, numberAccount);
                bankAccounts[i] = bankAccount;
                i++;
            }
        }

        /// <summary>
        /// Write a C# program to display all details for those bank accounts.
        /// </summary>
        static void DisplayBankAccounts(BankAccount[] bankAccounts, int n)
        {
            int i = 0;
            while (i < n)
            {
                bankAccounts[i].DisplayDetails();
                i++;
            }
        }

        /// <summary>
        /// Write a C# program to calculate the average interest of the bank accounts.
        /// </summary>
        static void AvarageInterest(BankAccount[] bankAccounts, int n)
        {
            int i = 0;
            decimal avarageInterest = 0m;
            while (i < n)
            {
                avarageInterest += bankAccounts[i].Interest;
                i++;
            }
            Console.WriteLine("The avarange interest for the bank accounts is: " + avarageInterest / n);
        }

        /// <summary>
        /// Write a C# program to deposite double of the balance, for each account which owner name contains 'Billy' word.
        /// </summary>
        static void DepositeDoubleBalanceForOwnerBill(BankAccount[] bankAccounts, int n)
        {
            for (int i = 0; i < n; i++)
            {
                BankAccount bankAccount = bankAccounts[i];
                if (bankAccount.Owner.Contains("Billy"))
                {
                    bankAccount.Deposit(bankAccount.Balance * 2);
                }
            }
        }

        /// <summary>
        /// Write a C# program to withdrawal a half of the balance, for each account which account number contains '2222'.
        /// </summary>
        static void WithdrawalHalfBalance(BankAccount[] bankAccounts, int n)
        {
            for (int i = 0; i < n; i++)
            {
                BankAccount bankAccount = bankAccounts[i];
                if (bankAccount.AccountNumber.Contains("2222"))
                {
                    bool successful = bankAccount.Withdrawal(bankAccount.Balance * 1 / 2);
                    if (successful)
                    {
                        Console.WriteLine("The withdrawal action was successful");
                    }
                }
            }
        }

        static decimal GetDecimalFromConsole(string message = null)
        {
            if (!string.IsNullOrWhiteSpace(message))
            {
                Console.WriteLine(message);
            }
            string consoleInput = Console.ReadLine();
            return decimal.Parse(consoleInput);
        }

        static string GetStringFromConsole(string message = null)
        {
            if (!string.IsNullOrWhiteSpace(message))
            {
                Console.WriteLine(message);
            }
            return Console.ReadLine();
        }

        static int GetIntFromConsole(string message = null)
        {
            if (!string.IsNullOrWhiteSpace(message))
            {
                Console.WriteLine(message);
            }
            string consoleInput = Console.ReadLine();
            return int.Parse(consoleInput);
        }
    }
}
