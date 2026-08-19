using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Text;
using System.Transactions;
using System.Xml;

namespace ConsoleApp1.Problem_Solving.Loop
{
    public class LoopProblemSolving
    {
        public void StudentMarksSystem()
        {
            string name;
            int rollNo;
            Console.WriteLine("Enter your Name : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your Roll : ");
            rollNo = Convert.ToInt32(Console.ReadLine());

            int total = 0;
            int average = 0;
            int highest = 0;
            int lowest = 100;

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"enter the {i} : ");
                int marks = Convert.ToInt32(Console.ReadLine());
                total += marks;
                average += (marks / 5);

                if (highest < marks)
                {
                    highest = marks;
                }

                if (lowest > marks)
                {
                    lowest = marks;
                }

            }

            Console.WriteLine("your name  is : " + name);
            Console.WriteLine("your rollNo  is : " + rollNo);
            Console.WriteLine("total number is : " + total);
            Console.WriteLine("average number is : " + average);
            Console.WriteLine("highest number is : " + highest);
            Console.WriteLine("lowest number is : " + lowest);


        }

        public void EvenOddAnalyzer()
        {
            int even = 0;
            int odd = 0;
            int evenCount = 0;
            int oddCount = 0;


            for (int i = 1; i <= 10; i++)
            {

                Console.WriteLine($"Enter number {i}");
                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"this are the even number : {number}");
                if (number % 2 == 0)
                {
                    Console.WriteLine("event number : " + number);
                    evenCount++;

                    even += number;

                    continue;
                }
                if (number % 2 == 1)
                {
                    Console.WriteLine("Odd number is : " + number);
                    oddCount++;
                    odd += number;
                }


            }
            Console.WriteLine(even);
            Console.WriteLine(odd);
            Console.WriteLine(evenCount);
            Console.WriteLine(oddCount);
        }

        public void NumberGuessingGame()
        {
            int secretNumber = 76;
            int guessCount = 0;
            while (true)
            {
                Console.WriteLine("guess the number : ");
                int guess = Convert.ToInt32(Console.ReadLine());

                guessCount++;
                if (secretNumber < guess)
                {
                    Console.WriteLine("to high ");

                }
                if (secretNumber > guess)
                {
                    Console.WriteLine("to low ");

                }
                if (secretNumber == guess)
                {
                    Console.WriteLine("your are win");
                    break;
                }
            }
        }

        public void LoginSystem()
        {
            string pass = "1234";
            string user = "rial";
            int guessCount = 0;

            while (true)
            {
                Console.WriteLine("enter the user id : ");
                string userId = Console.ReadLine();
                Console.WriteLine("enter the password :");
                string password = Console.ReadLine();

                guessCount++;
                if (pass == password && user == userId)
                {
                    Console.WriteLine("correct userid and pass ");
                    break;
                }
                else
                {

                    Console.WriteLine("incorrect userid and pass ");
                }

                if (guessCount == 3)
                {
                    break;
                }
            }
        }
        public void ATMMenu()
        {
            int balance = 5000;
            int choice ;

            do
            {
                // menu 
                Console.WriteLine("1.balance");
                Console.WriteLine("2.deposite");
                Console.WriteLine("3.witdraw");
                Console.WriteLine("4.exit");

                Console.WriteLine("Enter your choice ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine(balance);
                        break;
                    case 2: 
                        Console.WriteLine("enter your deposit amount : ");
                        int deposit = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"your deposit amount is : {deposit}");
                        int currentBalance = (deposit + balance);
                        Console.WriteLine("total balance ${0}" , currentBalance);
                        break;
                    case 3:
                        Console.WriteLine("enter your Witdraw ammount : ");
                        int witdraw = Convert.ToInt32(Console.ReadLine()); 

                        if(witdraw < balance)
                        {
                            Console.WriteLine("Your witdraw amount is : ");
                            Console.WriteLine("Your current balance is : " + (balance - witdraw));

                        }
                        else
                        {
                            Console.WriteLine("insufficient balance");
                        }
                        break;
                        case 4:

                        Console.WriteLine("thank you ");
                        break; 
                }



            }
            while (choice != 4);
        }
    }
}
