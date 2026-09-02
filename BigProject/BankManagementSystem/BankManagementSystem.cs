using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace ConsoleApp1.BigProject.BankManagementSystem
{
    public class BankManagementSystem
    {
        class Account
        {
            public int AccountId { get; set; }
            public string Name { get; set; }
            public string Number  { get; set; }
            public string AccountType { get; set; }
            public decimal Balance { get; set; }
            public string Address { get; set; }
        }
     


        public void BankManagementSystemProject()
        {
            Account[] accounts = new Account[10];
            int accountCount = 0;
            int choice;
            do
            {
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Show All Accounts");
                Console.WriteLine("3. Search Account");
                Console.WriteLine("4. Deposit Money");
                Console.WriteLine("5. Withdraw Money");
                Console.WriteLine("6. Transfer Money");
                Console.WriteLine("7. Update Account");
                Console.WriteLine("8. Delete Account");
                Console.WriteLine("9. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                    Console.WriteLine(" Create Account ");
                    break;

                    case 2:
                        Console.WriteLine("Show All Accounts");
                        break;
                    case 3:
                        Console.WriteLine("Search Account");
                        break;
                    case 4:
                        Console.WriteLine("Deposit Money");
                        break;
                    case 5:
                        Console.WriteLine("Withdraw Money");
                        break; 
                    case 6:
                        Console.WriteLine("Transfer Money");
                        break; 
                    case 7:
                        Console.WriteLine("Update Account");
                        break; 
                    case 8:
                        Console.WriteLine("Delete Account");
                        break; 

                }
            }
            while (choice != 9);

        }
    }
}
