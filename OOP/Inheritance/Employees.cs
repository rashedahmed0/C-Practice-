using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Inheritance
{
    internal class Employees : Person 
    {
        internal int Salary; 
        internal void AcceptEmployee(int salary)
        {
            this.Salary = salary; 

        }

        internal void DisplayEmployee()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Age  : " + Age);
            Console.WriteLine("Salary : " + Salary );
        }
    }
}
