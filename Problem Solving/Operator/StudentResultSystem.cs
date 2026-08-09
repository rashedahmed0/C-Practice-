using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Problem_Solving.Operator
{
    public class StudentResultSystem
    {
        string Name, Roll, Bangla, English, Math, ICT, Science;
        public void AcceptStudentInfo()
        {
            Console.WriteLine("Enter the Studnet Name : ");
            Name  = Console.ReadLine(); 
            Console.WriteLine("Enter the Studnet Roll : ");
            Roll = Console.ReadLine();
            Console.WriteLine("Enter the Studnet Bangla : ");
            Bangla = Console.ReadLine();
            Console.WriteLine("Enter the Studnet English : ");
            English = Console.ReadLine();
            Console.WriteLine("Enter the Studnet Math : ");
            Math = Console.ReadLine();
            Console.WriteLine("Enter the Studnet ICT : ");
            ICT = Console.ReadLine();
            Console.WriteLine("Enter the Studnet Science : ");
            Science = Console.ReadLine();
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine("Student Name : " + Name);
            Console.WriteLine("Student Roll : " + Roll);
            Console.WriteLine("Student Bangla : " + Bangla);
            Console.WriteLine("Student English : " + English);
            Console.WriteLine("Student Math : " + Math);
            Console.WriteLine("Student ICT : " + ICT);
            Console.WriteLine("Student Science : " + Science);
        }

        public string CalculationStudentOperator()
        {
            int BanglaMarks  = int.Parse(Bangla); ;
            int EnglishMarks = Convert.ToInt32(English);
            int MathMarks = int.Parse(Math);
            int ICTMarks = Convert.ToInt32(ICT);
            int ScienceMarks = int.Parse(Science);

            int totalNumber = BanglaMarks +  EnglishMarks + MathMarks + ICTMarks + ScienceMarks; 
            Console.WriteLine("Total Marks : " + totalNumber);

            int average = totalNumber / 5;
            Console.WriteLine("Average Marks : " + average);

            double percentage50 = (50.0 /totalNumber) * 100;
            Console.WriteLine("Percentage : " + percentage50);

            string grade = average >=80 ? " A+" :
                average >69 && average < 80 ? " A" :
                average > 59 && average < 70 ? " A-" :
                average > 49 && average < 60 ? " B" :
                average > 39 && average < 50 ? " C" :
                average > 32 && average < 40 ? " D" : " F";
            
            Console.WriteLine("Grade : " + grade);


            string highLowMarks = average >= 80 ? "highest marks " : "lowest Makrs ";
               Console.WriteLine("You got  : " + highLowMarks);

            string PassFail = average >= 33 ? "pass" : "fail ";
            Console.WriteLine("You are : " + PassFail);

            return grade; 


        }
    }
}
