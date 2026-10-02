using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.RECAP1.Condition
{
    internal class Conditions
    {
        internal void IfExample()
        {
            int age = 18;
            if (age >= 18)
            {
                Console.WriteLine("Eligible for vote");
            }

            string passWord = "pass";
            if(passWord == "pass")
            {
                Console.WriteLine("Login successful");
            }
        }

        internal void IFELSEExample() {

            int age = 17;
            if (age >= 18)
            {
                Console.WriteLine("you are eligible ");
            }
            else
            {
                Console.WriteLine("you are not eligible ");
            }

            int marks = 33;
            if(marks >= 33)
            {
                Console.WriteLine("you are pass");
            }
            else
            {
                Console.WriteLine("you are fail");
            }

            string password = "123";
            if(password == "123")
            {
                Console.WriteLine("login successfull");
            }
            else
            {
                Console.WriteLine("login failed");
            }

            int number = 78;
            if(number >= 80)
            {
                Console.WriteLine("A+");
            }
           else if (number >= 70 && number < 80)
            {
                Console.WriteLine("A");
            }
           else if (number >= 60 && number < 70)
            {
                Console.WriteLine("A-");
            }
           else 
            {
                Console.WriteLine("F");
            }

            int temp = 40; 
            if(temp > 30)
            {
                Console.WriteLine("today is a hot day ");
            }
            else
            {
                Console.WriteLine("today is normal day ");
            }


        }

        internal void Switch()
        {
            int day = 1;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Saturday");
                    break;
                case 2:
                    Console.WriteLine("Sunday");
                    break;
                case 3:
                    Console.WriteLine("Monday");
                    break;
                case 4:
                    Console.WriteLine("Tuesday");
                    break;
                case 5:
                    Console.WriteLine("Wednesday");
                    break;
                case 6:
                    Console.WriteLine("Thursday");
                    break;
                default:
                    Console.WriteLine("Friday");
                    break; 

            }
        }
    }
}
