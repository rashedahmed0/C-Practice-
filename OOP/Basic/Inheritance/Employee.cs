using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Basic.Inheritance
{
    internal class Employee : Manager
    {
        string designation;
        string name;
        internal void EmployeeContainer()
        {
            designation = "Junior developer";
            name = "Rashed";
            Console.WriteLine("name is : {0} , designation is : {1} " , name , designation);

        }
    }
}
