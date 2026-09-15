using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Basic
{
    public class Students
    {
        public int StudentRoll;
        public string StudentName;
        public int StudentAge;
        public string StudentAddress;
        public string StudentGender;

        public void Accept(int StudentRoll , string StudentName , int StudentAge , string StudentAddress , string StudentGender )
        {
            this.StudentRoll= StudentRoll;
            this.StudentName = StudentName;
            this.StudentAge = StudentAge; 
            this.StudentAddress = StudentAddress;
            this.StudentGender = StudentGender; 

        }

        public void Display()
        {
            Console.WriteLine($"Student roll is : {StudentRoll} , StudentName is {StudentName} , student age is : {StudentAge} , student address is : {StudentAddress} and he is a {StudentGender}");
        }
             

    }
}
