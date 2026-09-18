using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Basic.Constractor
{
    internal class Constructor1
    {
        static int a, b;
        int x, y; 

        static Constructor1()
        {
            a = 10;
            b = 20;
            Console.WriteLine("static constructor " +(a + b) );
        }

        internal Constructor1()
        {
            x = 100;
            y = 200; 
            Console.WriteLine("default constructor " +(x + b ));
        }

        internal Constructor1(int x , int  y ) {
            this.x = x; 
            this.y = y; 
            Console.WriteLine("parameter constructor " + (x + y ));
        }
    }
}
