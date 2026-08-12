using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Problem_Solving.Condition.BasicProblem
{
    public class IfElseProblem
    {
        public void IfElseProblemPractice()
        { 
            int number = 12;
            if(number %2 == 0)
            {
                Console.WriteLine("{0} number is even " , number);
            }
            else
            {
                Console.WriteLine("{0} number is odd ", number);
            }

            int marks = 45;
            if (marks < 33)
            {
                Console.WriteLine("you are fail ");

            }
            else
            {
                Console.WriteLine("You are pass ");
            }

            int age = 18;
            if(age > 17)
            {
                Console.WriteLine("you are adult ");
            }
            else
            {
                Console.WriteLine("your are minor ");
            }



            if(number > 0)
            {
                Console.WriteLine("this is positive number ");
            }
            else
            {
                Console.WriteLine("This is negative number ");
            }

            int purchasePrice = 5000;
            int sellPrice = 5500;
            if (purchasePrice < sellPrice)
            {
                Console.WriteLine("you are profitable ");
            }
            else
            {
                Console.WriteLine("You are not profitable ");
            }

            int firstNumber = 15;
            int secondNumber = 20;

            //if(firstNumber > secondNumber)
            //{
            //    Console.WriteLine(firstNumber);
            //}
            //else
            //{
            //    Console.WriteLine(secondNumber);
            //}

            int result = firstNumber > secondNumber ? firstNumber : secondNumber;
            Console.WriteLine(result );
        }
    }
}
