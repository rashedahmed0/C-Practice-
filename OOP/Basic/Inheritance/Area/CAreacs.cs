using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Basic.Inheritance.Area
{
    internal class CAreacs
    {
        internal int Pram1;
        internal float area;

        internal void AccecptCircle(int pram1)
        {
            this.Pram1 = pram1;
        }
        internal void AreaCircle()
        {
             area =  (float)(3.1416 * Pram1 * Pram1) ;


        }
        internal void DisplaryCircle()
        {
            Console.WriteLine("circle Area is : " + area);
        }
    }
}
