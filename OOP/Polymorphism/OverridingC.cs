using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Polymorphism
{
    internal class OverridingC: OverridingP
    {
        internal override void func()
        {
            Console.WriteLine("this is child class");
        }  
    }
}
