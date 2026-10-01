using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Basic.Inheritance
{
    internal class Manager : Boss
    {
        int salary ;

        internal void ManagerContainer()
        {
            salary = 12000;
            Console.WriteLine("salary is : {0}" , salary);
        }
    }
}
