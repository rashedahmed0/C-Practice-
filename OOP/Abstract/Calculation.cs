using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleApp1.OOP.Abstract
{
    internal abstract class Calculation
    {
        internal int a;
        internal int b;

        internal void AcceptCalcution(int a , int b)
        {
            this.a = a;
            this.b = b;
        }

        internal abstract void Sums();
        internal abstract void Minuss();

        internal abstract void Multi();
    }
}
