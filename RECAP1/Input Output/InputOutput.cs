using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.RECAP1.Input_Output
{
    internal class InputOutput
    {
        internal void InPut()
        {
            int a;
            int b;

            Console.WriteLine("enter the first number : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the second number : ");

            b = int.Parse(Console.ReadLine());

            int sum = a + b;
            Console.WriteLine("the sum of {0}  and {1}  is : {2}", a, b, sum);


            int minus = a - b;
            Console.WriteLine("the difference of {0}  and {1}  is : {2}", a, b, minus);

        }
    }
}
