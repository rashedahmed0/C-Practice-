using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Basic.Constractor
{
    internal class CopyConstructor
    {
        int a, b; 

        internal CopyConstructor()
        {
            a = 2;
            b = 3;
            Console.WriteLine("minus" + (a - b));

        }
        internal CopyConstructor(int a , int b )
        {
            Console.WriteLine("div : " + (b / a ));
        }
        internal CopyConstructor(CopyConstructor obj)
        {
            this.a = obj.a;
            this.b = obj.b;
            Console.WriteLine("sum" + a + b );
        }
    }
}
