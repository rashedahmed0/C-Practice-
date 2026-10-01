using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Abstract
{
    internal class Sum : Calculation
    {
        internal override void Minuss()
        {
            Console.WriteLine("Minus : {0} ", a - b);
        }

        internal override void Multi()
        {
            Console.WriteLine("Multi : {0} ", a * b);
        }

        internal override void Sums()
        {
            Console.WriteLine("sum : {0} " , a + b); 

        }
    }
}
