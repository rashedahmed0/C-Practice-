using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Problem_Solving.Condition.BasicProblem
{
    internal class IfExample
    {
        public void IfProblemFirst()
        {

            int number = 2;
            if (number > 0)
            {
                Console.WriteLine($"{number} is a positive number");
            }
            if(number % 2 == 0)
            {
                Console.WriteLine("{0} is a even number " , number);
            }
            int age = 26;
            if(age >= 18)
            {
                Console.WriteLine("you are elegible for vote because your age is {0} years old " , age );
            }
            int marks = 78;

            if(marks >= 33)
            {
                Console.WriteLine("your are passed your number is : {0} ", marks);

            }

            int shoppingAmmount = 1500;
            if(shoppingAmmount > 1000)
            {
                Console.WriteLine("you got free delivery ");

            }

            Console.WriteLine("Enter your password ");
            int pass = Convert.ToInt32(Console.ReadLine());
            if (pass == 1234)
            {
                Console.WriteLine("Your password is correct ");
            }

            int salary = 50000;
            if(salary >= 50000)
            {
                Console.WriteLine("You are eligible for bonus ");
            }
        }
    }
}
