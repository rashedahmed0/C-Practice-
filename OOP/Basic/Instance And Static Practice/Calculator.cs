using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace ConsoleApp1.OOP.Basic.Instance_And_Static_Practice
{
    internal class Calculator
    {
        internal int a;
        internal int b;

        public void Accept (int a, int b) {
           this.a = a;
           this.b = b;
        }
        public void Add () {
            Console.WriteLine("Add : " + (a + b));
        }
        public void Minus () {
            Console.WriteLine("Minus : " + (a - b));
        }
        public void Mult () {
            Console.WriteLine("Mult : " + (a * b));
        }
        public void Div () {
            Console.WriteLine("Div : " + (a / b));
        }

    }
}
