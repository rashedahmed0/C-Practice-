using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Abstract
{
    internal class Dog : Animal
    {
        internal override void Sound()
        {
            Console.WriteLine("dog name is {0} . its sound ghew ghew" , Name);
        }
    }
}
