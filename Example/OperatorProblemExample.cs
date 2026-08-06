using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Example
{
    public class OperatorProblemExample
    {
        public void ArithmeticOperator()
        {
            string a = "10";
            string b = "5";
            int num1 = int.Parse(a);
            int num2 = Convert.ToInt32(b);

            //ArithmeticOperator + - * / 

            int sum = num1 + num2;
            Console.WriteLine("sum of num1 and num2 is : " + sum);
            int sub = num1 - num2;
            Console.WriteLine("sub of num1 and num2 is : " + sub);
            int mul = num1 * num2;
            Console.WriteLine("mul of num1 and num2 is : " + mul);
            int div = num1 / mul;
            Console.WriteLine("div of num1 and num2 is : " + div);
        }

        public void AssignmentOperator()
        {
            int a = 10;
            Console.WriteLine("value of a is : " + a);
            a += 5;
            Console.WriteLine("value of a is : " + a);
            a -= 2;
            Console.WriteLine("value of a is : " + a);
            a /= 2;
            Console.WriteLine("value of a is : " + a);
            a *= 3;
            Console.WriteLine("value of a is : " + a);
        }

        public void ComparisonOperator() 
        {
            int a = 10;
            int b = 5; 

            Console.WriteLine("a == b : " + (a == b));
            Console.WriteLine("a != b : " + (a != b));
            Console.WriteLine("a > b : " + (a > b));
            Console.WriteLine("a < b : " + (a < b));
            Console.WriteLine("a >= b : " + (a >= b));
            Console.WriteLine("a <= b : " + (a <= b));




        }
    }
}
