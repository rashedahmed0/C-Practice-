using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Example
{
    public class Condition
    {
        public void IfExample()
        {
            //if 
            //int ageForVote = 18;
            //string name = "Rashed";
            int ageForVote;
            string name;
            Console.WriteLine("enter your name : ");
            name = Console.ReadLine();
            Console.WriteLine("enter your Age : ");
            ageForVote = int.Parse(Console.ReadLine());
            if (ageForVote >= 18)
            {
                Console.WriteLine("{0} are elegible for Vote becaurse his age is {1} years ", name, ageForVote);
            }
        }

        public void IfElseExample()
        {
            int ageForVote;
            string name;
            Console.WriteLine("Enter your Name :");
            name = Console.ReadLine();
            Console.WriteLine("Enter Your Age : ");
            ageForVote = Convert.ToInt32(Console.ReadLine());

            if (ageForVote >= 18)
            {
                Console.WriteLine($"{name} is elegible for vote because he is {ageForVote} years old ");

            }
            else
            {
                Console.WriteLine("{0} is note elegible for vote because he is {1} year old ", name, ageForVote);
            }
        }

        public void ElseIfExample()
        {
            int marks;
            string name;
            Console.WriteLine("Enter your name : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Your Marks :");
            marks = int.Parse(Console.ReadLine());

            if (marks >= 80)
            {
                Console.WriteLine("{0} got A+ Your number is : {1}", name, marks);
            }
            else if (marks >= 70 && marks <= 79)
            {
                Console.WriteLine("{0} got A Your number is : {1}", name, marks);
            }
            else if (marks >= 60 && marks <= 69)
            {
                Console.WriteLine("{0} got B+ Your number is : {1}", name, marks);
            }
            else if (marks >= 50 && marks <= 59)
            {
                Console.WriteLine("{0} got C Your number is : {1}", name, marks);
            }
            else if (marks >= 40 && marks <= 49)
            {
                Console.WriteLine("{0} got D Your number is : {1}", name, marks);
            }
            else if (marks >= 33 && marks <= 39)
            {
                Console.WriteLine("{0} got E Your number is : {1}", name, marks);
            }
            else
            {
                Console.WriteLine("{0} are Fail Your number is : {1}", name, marks);
            }
        }

        public void Nestedif()
        {
            int age = 26;
            bool hasNID = false;

            if (age >= 18)
            {
                if (hasNID == true)
                {
                    Console.WriteLine("You can vote ");
                }
                else
                {
                    Console.WriteLine("your can not vote ");

                }
            }
            else
            {
                Console.WriteLine("your can not vote ");
            }

        }


        public void switchExample()
        {
            int day = 3;

            switch (day)
            {
                case 0:
                    Console.WriteLine("saturday");
                    break;

                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 3:
                    Console.WriteLine("Monday");
                    break;
                case 4:
                    Console.WriteLine("Tuesday");
                    break;
                default:
                    Console.WriteLine("no Day ");
                    break; 

            }
        }


        public void SwitchExpression()
        {
            int day = 4;
            string dayName = day switch
            {
                1 => "saturday",
                2 => "sunday",
                3 => "monday",
                4 => "tuesday",
                5 => "wednesday",
                6 => "thusday",
                7 => "friday",
                _ => "invalid day "

            };
            Console.WriteLine(dayName); 
        }
    }
}
