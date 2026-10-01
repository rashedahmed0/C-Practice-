using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Basic.Inheritance.Area
{
    internal class RactangleArea : TArea
    {
        internal int param3;
        internal float Ractangle;

        internal void AcceptRactange(int param3)
        {
            this.param3 = param3;
        }
        internal void RactangeArea()
        {
            Ractangle = param3 * Pram1;
        }
        internal void DisplayRactange()
        {
            Console.WriteLine("Ractange Area : " + Ractangle);
        }
    }
}
