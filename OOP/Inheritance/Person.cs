using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Inheritance
{
    internal class Person
    {
        internal string Name;
        internal int Age;


        internal void AcceptPerson(string name, int age )
        {
            this.Name = name;
            this.Age = age; 
        }

        internal void DisplayPerson()
        {
            Console.WriteLine("name : " + Name);
            Console.WriteLine("Age : " + Age);
        }
    }
}
