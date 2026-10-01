using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Encapsulation
{
    internal class Banks
    {
        private string BankHolderName;
        private int AccountNumber;
        private int Balance; 
        
        internal  void AcceptBank(string name , int number , int balance)
        {
            this.BankHolderName = name;
            this.AccountNumber = number; 
            this.Balance = balance;
        }

        internal void Deposit (int amount)
        {
            Balance = Balance + amount;
        }  
        internal void Withdraw( int amount)
        {
            Balance = Balance - amount;
        }
       internal void Display()
        {
            Console.WriteLine("BankHolderName : " + BankHolderName);
            Console.WriteLine("AccountNumber : " + AccountNumber);
            Console.WriteLine("Balance : " + Balance);
        }

    }
}
