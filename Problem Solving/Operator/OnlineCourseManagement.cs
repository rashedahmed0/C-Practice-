using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ConsoleApp1.Problem_Solving.Operator
{
    public class OnlineCourseManagement
    {
        string StudentName, CourseName;
        int QuizMarks, AssignmentMarks, MidMarks, FinalMarks;

        public void AcceptOnlineCourse()
        {
            Console.WriteLine("Enter the Studentname : ");
            StudentName = Console.ReadLine();
            Console.WriteLine("Enter the CourseName : ");
            CourseName = Console.ReadLine();

            Console.WriteLine("Enter the QuizMarks : ");
            QuizMarks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the AssignmentMarks : ");
            AssignmentMarks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the FinalMarks : ");
            FinalMarks = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayOnlineClass()
        {
            Console.WriteLine("Student Name : " + StudentName);
            Console.WriteLine("CourseName : " + CourseName);
            Console.WriteLine("QuizMarks : " + QuizMarks);
            Console.WriteLine("AssignmentMarks : " + AssignmentMarks);
            Console.WriteLine("FinalMarks : " + FinalMarks);

        }

    }
}
