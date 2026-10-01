using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ConsoleApp1.OOP.Polymorphism
{
    public class OverloadingExmple
    {
        public void add(int a , int b)
        {
            Console.WriteLine(a + b);
        }
        public void add(int a , int b , int c)
        {
            Console.WriteLine(a + b + c);
        }
        public void add(int a , int b , int c , int d )
        {
            Console.WriteLine(a + b + c+ d);
        }

    }
}
