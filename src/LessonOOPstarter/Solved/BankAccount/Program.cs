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
            // If you want to read all dates from console.
            //int n = 2;
            //BankAccount[] bankAccounts = new BankAccount[n];
            //ReadBankAccounts(bankAccounts, n);

            int n = 2;
            BankAccount[] bankAccounts = new BankAccount[n];
            bankAccounts[0] = new BankAccount("Billy", 8200m, 5m, "2222 3234 4313 4353");
            bankAccounts[1] = new BankAccount("Anne", 5600m, 6m, "9999 4323 1244 5421");

            DisplayBankAccounts(bankAccounts);
            AvarageInterest(bankAccounts);
            DepositeDoubleBalanceForOwnerBill(bankAccounts);
            WithdrawalHalfBalance(bankAccounts);
        }

        /// <summary>
        /// Write a C# program to read the details for a bank account.
        /// </summary>
        static BankAccount ReadDetailsForBankAccount()
        {
            string owner, numberAccount;
            decimal interest, balance;

            Console.Write("Owner = ");
            owner = Console.ReadLine();

            Console.Write("NumberAccount = ");
            numberAccount = Console.ReadLine();

            Console.Write("Interest = ");
            interest = decimal.Parse(Console.ReadLine());

            Console.Write("Balance = ");
            balance = decimal.Parse(Console.ReadLine());

            BankAccount bankAccount = new BankAccount(owner, balance, interest, numberAccount);
            return bankAccount;
        }

        /// <summary>
        /// Write a C# program to read all details for the bank accounts.
        /// </summary>
        static void ReadBankAccounts(BankAccount[] bankAccounts)
        {
            int i = 0;

            while (i < bankAccounts.Length)
            {
                BankAccount bankAccount = ReadDetailsForBankAccount();
                bankAccounts[i] = bankAccount;
                i++;
            }
        }

        /// <summary>
        /// Write a C# program to display all details for those bank accounts.
        /// </summary>
        static void DisplayBankAccounts(BankAccount[] bankAccounts)
        {
            int i = 0;
            while (i < bankAccounts.Length)
            {
                bankAccounts[i].DisplayDetails();
                i++;
            }
        }

        /// <summary>
        /// Write a C# program to calculate the average interest of the bank accounts.
        /// </summary>
        static void AvarageInterest(BankAccount[] bankAccounts)
        {
            int i = 0;
            int arrayLength = bankAccounts.Length;
            decimal avarageInterest = 0m;
            while (i < arrayLength)
            {
                avarageInterest += bankAccounts[i].interest;
                i++;
            }
            Console.WriteLine("The avarange interest for the bank accounts is: " + avarageInterest / arrayLength);
        }

        /// <summary>
        /// Write a C# program to deposite double of the balance, for each account which owner name contains 'Billy' word.
        /// </summary>
        static void DepositeDoubleBalanceForOwnerBill(BankAccount[] bankAccounts)
        {
            for (int i = 0; i < bankAccounts.Length; i++)
            {
                BankAccount bankAccount = bankAccounts[i];
                if (bankAccount.owner.Contains("Billy"))
                {
                    bankAccount.Deposit(bankAccount.balance * 2);
                }
            }
        }

        /// <summary>
        /// Write a C# program to withdrawal a half of the balance, for each account which account number contains '2222'.
        /// </summary>
        static void WithdrawalHalfBalance(BankAccount[] bankAccounts)
        {
            for (int i = 0; i < bankAccounts.Length; i++)
            {
                BankAccount bankAccount = bankAccounts[i];
                if (bankAccount.accountNumber.Contains("2222"))
                {
                   bankAccount.Withdrawal(bankAccount.balance * 1 / 2);
                }
            }
        }
    }
}
