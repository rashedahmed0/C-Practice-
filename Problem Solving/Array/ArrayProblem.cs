using System;
using System.Collections.Generic;
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

            }

            int highestNubmerIndex = System.Array.IndexOf(marks, heightNumber);

            int average = sum / marks.Length; 
            Console.WriteLine("total marks is : " + sum);
            Console.WriteLine("average marks is : " + average);
            Console.WriteLine("height marks is  : " + heightNumber);
            Console.WriteLine("Lowest marks is  : " + lowestNumber);
            Console.WriteLine("index of height number is : " + highestNubmerIndex);
        }
    }
}
