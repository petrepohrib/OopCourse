using System;

namespace BankAccount
{
    public static class Program
    {
        public static void Main() =>
            Console.WriteLine("Welcome to the OOP course 😉!");

        /// <summary>
        /// Write a C# program to read all details for the bank accounts.
        /// </summary>
        static void ReadBankAccounts(BankAccount[] bankAccounts, int n)
        {
            throw  new NotImplementedException("Implement me 🥺");
        }

        /// <summary>
        /// Write a C# program to display all details for those bank accounts.
        /// </summary>
        static void DisplayBankAccounts(BankAccount[] bankAccounts, int n)
        {
            throw new NotImplementedException("Implement me 🥺");
        }

        /// <summary>
        /// Write a C# program to calculate the average interest of the bank accounts.
        /// </summary>
        static void AvarageInterest(BankAccount[] bankAccounts, int n)
        {
            throw  new NotImplementedException("Implement me 🥺");
        }

        /// <summary>
        /// Write a C# program to deposite double of the balance, for each account which owner name contains 'Billy' word.
        /// </summary>
        static void DepositeDoubleBalanceForOwnerBill(BankAccount[] bankAccounts, int n)
        {
            throw new NotImplementedException("Implement me 🥺");
        }

        /// <summary>
        /// Write a C# program to withdrawal a half of the balance, for each account which account number contains '2222'.
        /// </summary>
        static void WithdrawalHalfBalance(BankAccount[] bankAccounts, int n)
        {
            throw new NotImplementedException("Implement me 🥺");
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
