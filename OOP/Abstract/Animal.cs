using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Abstract
{
    internal abstract class Animal
    {
        internal string Name; 
        internal void AcceptAnamal(string name )
        {
            this.Name = name;  
        }
        internal abstract void Sound();

        internal void DisplayAnimal()
        {
            Console.WriteLine("This animal name : " + Name );
        }

    }
}
