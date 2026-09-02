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

                        Console.WriteLine("Enter Account ID: ");
                        int accountId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter name : ");
                        string name = (Console.ReadLine());
                        Console.WriteLine("Enter number : ");
                        string number = (Console.ReadLine());
                        Console.WriteLine("Enter account type : ");
                        string accountType = (Console.ReadLine());
                        Console.WriteLine("Enter balance : ");
                        decimal balance = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Enter address : ");
                        string address = (Console.ReadLine());

                        Account obj = new Account();
                        obj.AccountId = accountId;
                        obj.Name = name;
                        obj.Number = number; 
                        obj.AccountType = accountType; 
                        obj.Balance = balance; 
                        obj.Address = address;

                        accounts[accountCount] = obj;
                        accountCount++;

                        Console.WriteLine("Account created successfully!");




                        break;

                    case 2:
                        Console.WriteLine("Show All Accounts");
                        for (int i = 0;  i < accountCount; i++)
                        {
                            Account account = accounts[i];
                            Console.WriteLine($"Account ID: {account.AccountId}, Name: {account.Name}, Number: {account.Number}, Account Type: {account.AccountType}, Balance: {account.Balance}, Address: {account.Address}");
                        } 

                        break;
                    case 3:
                        Console.WriteLine("Search Account");
                        Console.WriteLine("Enter Account ID to search: ");
                        int accuuntIdToSearch = int.Parse(Console.ReadLine());
                        for (int i = 0; i < accountCount; i++)
                        {
                            Account account = accounts[i];
                            if (accuuntIdToSearch == account.AccountId)
                            {
                                Console.WriteLine($"Account ID: {account.AccountId}, Name: {account.Name}, Number: {account.Number}, Account Type: {account.AccountType}, Balance: {account.Balance}, Address: {account.Address}");
                            }
                            
                        } 

                        break;
                    case 4:
                        Console.WriteLine("Deposit Money");
                        Console.WriteLine("Enter Account ID to deposit money: ");
                        int depositAccountId = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter amount to deposit: ");
                        decimal depositAmount = decimal.Parse(Console.ReadLine());
                        for (int i = 0; i < accountCount; i++)
                        {
                            Account account = accounts[i];
                            if (depositAccountId == account.AccountId)
                            {
                                account.Balance += depositAmount;
                            } 

                        } 
                        break;
                    case 5:
                        Console.WriteLine("Withdraw Money");

                        Console.WriteLine("enter withdrawal Id: ");
                        decimal withdrawId = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter withdrawal amount: ");
                        decimal withdrawalAmount = decimal.Parse(Console.ReadLine());
                        for(int i = 0; i < accountCount; i++)
                        {
                            Account account = accounts[i];
                            if (withdrawId == account.AccountId && withdrawalAmount <= account.Balance && account.Balance > 0 )
                            {
                                account.Balance -= withdrawalAmount; 
                                Console.WriteLine("withdrawal successful");
                            }

                        }
                        break; 
                    case 6:
                        Console.WriteLine("Transfer Money");

                        Console.WriteLine("Enter from Account ID: ");
                        int fromAccountId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter to Account ID: ");
                        int toAccountId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter transfer amount: ");
                        decimal transferAmount = decimal.Parse(Console.ReadLine());

                        for(int i = 0; i < accountCount; i++)
                        {
                            Account account = accounts[i]; 
                            if(fromAccountId == account.AccountId)
                            {
                                if(transferAmount <= account.Balance && account.Balance > 0)
                                {
                                    account.Balance -= transferAmount;
                                    Console.WriteLine("Transfer successful");
                                }
                            }
                            if(toAccountId == account.AccountId)
                            {
                                account.Balance += transferAmount;
                            }

                        }
                        break; 
                    case 7:
                        Console.WriteLine("Update Account");

                        Console.WriteLine("Enter Account ID to update: ");
                        int accountIdToUpdate = int.Parse(Console.ReadLine());

                        for(int i = 0; i < accountCount; i++)
                        {
                            Account account = accounts[i];
                            if (accountIdToUpdate == account.AccountId)
                            {
                                Console.WriteLine("Enter name : ");
                                 name = (Console.ReadLine());
                                Console.WriteLine("Enter number : ");
                                 number = (Console.ReadLine());
                                Console.WriteLine("Enter account type : ");
                                 accountType = (Console.ReadLine());
                                Console.WriteLine("Enter address : ");
                                 address = (Console.ReadLine());

                                Account obj1 = new Account();
                                obj1.Name = name;
                                obj1.Number = number;
                                obj1.AccountType = accountType;
                                obj1.Address = address;

                                accounts[i] = obj1;

                                Console.WriteLine("Account updated successfully!");
                            }
                        }
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
