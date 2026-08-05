using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Problem_Solving.Variable
{
    public class ExamResultSystem
    {
        public void AcceptExamResultInformation()
        {
            string StudentName = "John Doe";
            int RollNumber = 1121;
            string Subject = "Mathematics";
            string MarksObtained = "85";
            string TotalMarks = "100";
            string Grade = "A";
            bool IsPassed = true;
            Console.WriteLine("Student Name : " + StudentName);
            Console.WriteLine("Roll Number : " + (byte)RollNumber);
            Console.WriteLine("Subject : " +  Subject);
            Console.WriteLine("Marks Obtained : " + int.Parse(MarksObtained));
            Console.WriteLine("Total Marks : " + Convert.ToDouble(TotalMarks));
            Console.WriteLine("Grade : " + Grade);
            Console.WriteLine("Is Passed : " + IsPassed);
        }
    }
}
