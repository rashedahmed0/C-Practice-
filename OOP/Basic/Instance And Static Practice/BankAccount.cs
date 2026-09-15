using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Basic.Instance_And_Static_Practice
{
    internal class BankAccount
    {
        // instance 
        internal int AccountNumber;
        internal string AccountHolder;
        internal int Balance;

        static string BankName = "BRAC";


        public void BankAccept(int AccountNumber , string AccountHolder , int Balance)
        {
            this.AccountNumber = AccountNumber;
            this.AccountHolder = AccountHolder;
            this.Balance = Balance; 
        }

        public void BankDisplay()
        {
            Console.WriteLine("AccountNumber " + AccountNumber);
            Console.WriteLine("AccountHolder " + AccountHolder);
            Console.WriteLine("Balance " + Balance);
            Console.WriteLine("BankName " + BankName);
        }


    }

}
