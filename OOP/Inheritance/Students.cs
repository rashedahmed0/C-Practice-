using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Inheritance
{
    internal class Students : Person
    {
        internal int Roll; 
        
        internal void AcceptStudent(int roll)
        {
            this.Roll = roll; 
        }
        internal void DisplayStudents()
        {
            Console.WriteLine("Name " + Name);
            Console.WriteLine("Age " + Age);
            Console.WriteLine("Roll " + Roll);
        }
    }
}
