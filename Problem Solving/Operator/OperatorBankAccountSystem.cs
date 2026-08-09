using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1.Problem_Solving.Operator
{
    public class OperatorBankAccountSystem
    {
        string CustomerName, AccountNumber, CurrentBalance, Deposit, Withdraw, PIN, EnterPIN;
        public void AcceptAccountInfo() {
         Console.WriteLine("Enter Customer Name:");
            CustomerName = Console.ReadLine();
            Console.WriteLine("Enter Account Number:");
            AccountNumber = Console.ReadLine();
            Console.WriteLine("Enter Current Balance:");
            CurrentBalance = Console.ReadLine();
            Console.WriteLine("Enter PIN:");
            PIN = Console.ReadLine();
          
        }
        public void DisplayAccountInfo()
        {
            Console.WriteLine("Customer Name: " + CustomerName);
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Current Balance: " + CurrentBalance);
            Console.WriteLine("Deposit: " + Deposit);
            Console.WriteLine("Withdraw: " + Withdraw);
            Console.WriteLine("PIN: " + PIN);
        }

        public void CalculateAccountBalance()
        {
            int pin = int.Parse(PIN);
            int SavePin = 1234;

            string  CorrectPin = pin == SavePin ? "Correct Pin" : "Incorrect Pic" ;
            Console.WriteLine(CorrectPin);

            int currentBalance = int.Parse(CurrentBalance);
            int deposit = Convert.ToInt32(Deposit);

            int newBalance = currentBalance + deposit;
            Console.WriteLine(newBalance);

            int depositAmount1 = 1000;
            int depositAmount2 = 2000;
            int depositAmount3 = 3000;

            int totalDeposit = depositAmount1 + depositAmount2 + depositAmount3; 
            Console.WriteLine("totaol diposit : " +  totalDeposit);

            int withdraw = Convert.ToInt32(Withdraw);

            bool IsPINCorrect = pin == SavePin ? true : false;
            Console.WriteLine("your pic is : " + IsPINCorrect);

            int SufficientBalance = currentBalance - withdraw; 
            Console.WriteLine("Sufficient Balance: " + SufficientBalance);

            string MinimumBalanceWarning = SufficientBalance < 500 ? "Warning : your balance is below minimum balance" : "Your balance is sufficient";
            Console.WriteLine(MinimumBalanceWarning);

            string TransactionNumber = SufficientBalance < 500 ? "Transaction Number: 123456" : "Transaction Number: 654321";
            Console.WriteLine(TransactionNumber);






        }

    }
}
