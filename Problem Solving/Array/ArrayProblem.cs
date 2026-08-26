using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp1.Problem_Solving.Array
{
    public class ArrayProblem
    {
        public void StudentMarksAnalyzer()
        {
            int[] marks = new int[5];



            Console.WriteLine("enter  your marks of Bangla : ");
            marks[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter  your marks of English : ");
            marks[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter  your marks of Math : ");
            marks[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter  your marks of Phycis : ");
            marks[3] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter  your marks of Chemistry : ");
            marks[4] = Convert.ToInt32(Console.ReadLine());


            int sum = 0;

            int heightNumber = 0;
            int lowestNumber = 100;

            foreach (int mark in marks)
            {
                sum += mark;
                if (mark > heightNumber)
                {
                    heightNumber = mark;
                }
                if(mark < lowestNumber)
                {
                    lowestNumber = mark; 
                }
                
            //System.Array.Sort(marks);
            //System.Array.Reverse(marks);
                Console.WriteLine("sort marks : " + mark);

            }

            int highestNubmerIndex = System.Array.IndexOf(marks, heightNumber);

            int average = sum / marks.Length; 
            Console.WriteLine("total marks is : " + sum);
            Console.WriteLine("average marks is : " + average);
            Console.WriteLine("height marks is  : " + heightNumber);
            Console.WriteLine("Lowest marks is  : " + lowestNumber);
            Console.WriteLine("index of height number is : " + highestNubmerIndex);

        }

        public void NumberSearchSystem()
        {
            int[] randomNumbers = { 2, 6, 8, 4 };
            while (true)
            {
                Console.WriteLine("Enter Your :");
                int guess = Convert.ToInt32(Console.ReadLine());
                bool found = false; 
                foreach(int randomNumber in randomNumbers)
                {
                    if(randomNumber == guess)
                    {
                        Console.WriteLine("You are right ");
                        found = true; 
                        break;
                    }
                }
                if (found)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("try again");
                }
            }
        }

        public void EvenOddAnalyzer()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int oddNumberCount = 0;
            int evenNubmerCount = 0;

            for (int i = 0; i < numbers.Length; i++) { 
                int element = numbers[i];
                if (element % 2 == 0)
                {
                    evenNubmerCount++;

                    Console.WriteLine("even numbers : " + element);
                }
                else {
                    oddNumberCount++;

                    Console.WriteLine("odd numbers " + element);
                }
            }
            Console.WriteLine("even Nubmer Count : " + evenNubmerCount); 
            Console.WriteLine("odd Nubmer Count : " + oddNumberCount); 



        }


    }
}
