using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Inheritance
{
    internal class Developer : Employees
    {
        internal string ProgrammingLanguage;
        internal void AcceptDeveloper(string language )
        {
            this.ProgrammingLanguage = language; 

        }
         internal void DsiplayDeveloper()
        {
            DisplayEmployee();
            Console.WriteLine("ProgrammingLanguage : " + ProgrammingLanguage);
        }

    }
}
