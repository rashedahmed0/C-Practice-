using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Basic.Inheritance.Area
{
    internal class TArea : CAreacs
    {
        internal int param2;
        internal float triangel;
         
        internal void TriangleAccept(int param2)
        {
            this.param2 = param2;

        }
        internal void TriangleArea()
        {
            triangel = (float)(0.5 * param2 * param2);
        }
        internal void DisplayAreat()
        {
            Console.WriteLine("triangel is :" + triangel);
        }
    }
}
