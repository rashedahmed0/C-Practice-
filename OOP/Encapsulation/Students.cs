using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Encapsulation
{
    internal class Students
    {
        private string StudentName ;
        private int StudentRoll;
        private int StudentAge;

        internal void AcceptStudent(string name , int roll , int age)
        {
            this.StudentName = name ;
            this.StudentRoll = roll;
            this.StudentAge= age;

        }

        internal void DisplayStudent()
        {
            Console.WriteLine("StudentName : {0}" , StudentName);
            Console.WriteLine("StudentRoll : {0}", StudentRoll);
            Console.WriteLine("StudentAge : {0}", StudentAge);
        }
    }
}
