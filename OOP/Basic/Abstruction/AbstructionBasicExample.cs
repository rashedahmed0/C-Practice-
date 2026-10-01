using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Basic.Abstruction
{
    internal abstract class AbstructionBasicExample
    {
        internal int a, b;
        internal float area; 
        internal void AcceptAB( int a , int b )
        {
            this.a = a;
            this.b = b; 
        }
        internal abstract void Triangle();
        internal abstract void Ractangle();

        internal void DisplayArea()
        {
            Console.WriteLine("Area is : " + area);
        } 
        
    }
}
