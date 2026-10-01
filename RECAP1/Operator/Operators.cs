using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ConsoleApp1.RECAP1.Operator
{
    internal class Operators
    {
        internal void Arithmatic()
        {
            int a = 5;
            int b = 2;

            int sum = a + b;
            int sub = a - b;
            int mul = a * b;
            int dib = a / b; 
        }

        internal void Comparism()
        {
            int a = 5;
            int b = 2;
            Console.WriteLine(a > b );
            Console.WriteLine(a < b );
            Console.WriteLine(a == b );
            Console.WriteLine(a != b );
            Console.WriteLine(a <= b );
            Console.WriteLine(a >= b );
        }

        internal void Logical()
        {
            bool a = true;
            bool b = false;

            Console.WriteLine(a && b);
            Console.WriteLine(a || b);
            Console.WriteLine(!a);
        }

        internal void IncreementDecreement()
        {
            int a = 5;
            int b = 5;
            a++;
            b--;
            Console.WriteLine(a);
            Console.WriteLine(b);

        }

        internal void TernaryOperator()
        {
            int a = 5;
            int b = 2;

            string  Compare = a > b ? "a is greater then b" : "b is greather then a";

            int age = 18;

            string eligibility = age >= 18 ? "Eligible for vote " : "not eligible for vote ";

            string password = "pass";

            string login = password == "pass" ? "login successfull" : "login failed ";

            int marks = 34;
            string result = marks >= 33 ? "pass" : "fail"; 



        }
    }
}
