using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Basic.Abstruction
{
    internal class AbstractBasixExamleChild : AbstructionBasicExample
    {
        internal override void Ractangle()
        {
            area = a * b; 
        }

        internal override void Triangle()
        {
            area = (a * b ) / 2;
        }
    }
}
