using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1.Problem_Solving.Variable
{
    public class StudentInformationSystem
    {
        string Name, Age, Height, Weight, GPA, Grade, IsPassed, ID, Class, Number, Bangla, english, math, science, socialScience, religion, ict;
        public void AcceptStudentInformation()
        {

            Console.WriteLine("Enter Student Name : ");
            Name = Console.ReadLine();

            Console.WriteLine("Enter Student Age : ");
            Age = Console.ReadLine();

            Console.WriteLine("Enter Student Height : ");
            Height = Console.ReadLine();

            Console.WriteLine("Enter Student Weight : ");
            Weight = Console.ReadLine();

            Console.WriteLine("Enter Student ID : ");
            ID = Console.ReadLine();

            Console.WriteLine("Enter Student Class : ");
            Class = Console.ReadLine();

            Console.WriteLine("Enter Student Number : ");
            Number = Console.ReadLine();

            Console.WriteLine("Enter Student Bangla : ");
            Bangla = Console.ReadLine();

            Console.WriteLine("Enter Student Weight : ");
            english = Console.ReadLine();

            Console.WriteLine("Enter Student math : ");
            math = Console.ReadLine();

            Console.WriteLine("Enter Student science : ");
            science = Console.ReadLine();

            Console.WriteLine("Enter Student socialScience : ");
            socialScience = Console.ReadLine();

            Console.WriteLine("Enter Student ict : ");
            ict = Console.ReadLine();

        }

        public void DisplayStudentInformation()
        {
            Console.WriteLine("Student Name : " + Name);
            Console.WriteLine("Student Age : " + Age);
            Console.WriteLine("Student Height : " + Height);
            Console.WriteLine("Student Weight : " + Weight);
            Console.WriteLine("Student ID : " + ID);
            Console.WriteLine("Student Class : " + Class);
            Console.WriteLine("Student Number : " + Number);
            Console.WriteLine("Student Bangla : " + Bangla);
            Console.WriteLine("Student English : " + english);
            Console.WriteLine("Student Math : " + math);
            Console.WriteLine("Student Science : " + science);
            Console.WriteLine("Student Social Science : " + socialScience);
            Console.WriteLine("Student ICT : " + ict);
        }

        public void CalculateGPA()
        {
            double doubleBangla = Convert.ToDouble(Bangla);
            double doubleEnglish = double.Parse(english);
            double doubleMath = Convert.ToDouble(math);
            double doubleScience = Convert.ToDouble(science);
            double doubleSocialScience = Convert.ToDouble(socialScience);
            double doubleICT = Convert.ToDouble(ict);
            double totalMarks = doubleBangla + doubleEnglish + doubleMath + doubleScience + doubleSocialScience + doubleICT;
            Console.WriteLine("Total Marks : " + totalMarks);
            double gpa = totalMarks / 6;
            GPA = gpa.ToString("0.00");
            Console.WriteLine("GPA : " + GPA);
        }

    }
}