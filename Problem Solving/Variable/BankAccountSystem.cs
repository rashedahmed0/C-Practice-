using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;

namespace ConsoleApp1.Problem_Solving.Variable
{
    public class BankAccountSystem
    {
        string  AccountHolderName, AccountNumber, AccountType, Balance, InterestRate, OverdraftLimit, MinimumBalance,   BankAddress, BankContactNumber;
        public void AcceptBankAccountInformation()
        {
            Console.WriteLine("Enter the Account Holder Name : ");
            AccountHolderName = Console.ReadLine();
            Console.WriteLine("Enter the Account Nubmer : ");
            AccountNumber = Console.ReadLine();
            Console.WriteLine("Enter the Account Type : ");
            AccountType = Console.ReadLine();
            Console.WriteLine("Enter the Balance : ");
            Balance = Console.ReadLine();
            Console.WriteLine("Enter the Interest Rate : ");
            InterestRate = Console.ReadLine(); 
            Console.WriteLine("Enter the Overdraft Limit : ");
            OverdraftLimit = Console.ReadLine();
            Console.WriteLine("Enter the Minimum Balance : ");
            MinimumBalance = Console.ReadLine();
            Console.WriteLine("Enter the Bank Address : ");
            BankAddress = Console.ReadLine();
            Console.WriteLine("Enter the Bank Contact Number : ");
            BankContactNumber = Console.ReadLine(); 


        }
        public void DisplayBankAccountInformation()
        {
            Console.WriteLine("Account Holder Name : " + AccountHolderName);
            Console.WriteLine("Account Number : " + AccountNumber);
            Console.WriteLine("Account Type : " + AccountType);
            Console.WriteLine("Balance : " + Balance);
            Console.WriteLine("Interest Rate : " + InterestRate);
            Console.WriteLine("Overdraft Limit : " + OverdraftLimit);
            Console.WriteLine("Minimum Balance : " + MinimumBalance);
            Console.WriteLine("Bank Address : " + BankAddress);
            Console.WriteLine("Bank Contact Number : " + BankContactNumber);
        }

        public void CalculateBankAccout()
        {
           string depositAmount, withdrawAmount;
            Console.WriteLine("Enter the Deposit Amount : ");
            depositAmount = Console.ReadLine();
            Console.WriteLine("Enter the Withdraw Amount : ");
            withdrawAmount = Console.ReadLine();

            double deposit = Convert.ToDouble(depositAmount);
            Console.WriteLine("Deposit Amount : " + deposit);
            double withdraw = double.Parse(withdrawAmount);
            Console.WriteLine("Withdraw Amount : " + withdraw);



        }
    }
}
