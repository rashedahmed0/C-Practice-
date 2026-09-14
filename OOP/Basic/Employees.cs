using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1.OOP.Basic
{
    internal class Employees
    {
        private int empId;
        private string empName;
        private int empAge; 

        public void Accept(int id , string name , int age )
        {
            this.empId = id;
            this.empName = name;
            this.empAge = age; 


        }
        public void Display()
        {
            Console.WriteLine("Employee id is {0} Employee name : {1} , Employee age : {2}" , empId , empName , empAge);
        }

    }
}
