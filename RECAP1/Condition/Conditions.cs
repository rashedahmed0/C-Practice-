using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.RECAP1.Condition
{
    internal class Conditions
    {
        internal void IfExample()
        {
            int age = 18;
            if (age >= 18)
            {
                Console.WriteLine("Eligible for vote");
            }

            string passWord = "pass";
            if(passWord == "pass")
            {
                Console.WriteLine("Login successful");
            }
        }

        internal void IFELSEExample() {

            int age = 17;
            if (age >= 18)
            {
                Console.WriteLine("you are eligible ");
            }
            else
            {
                Console.WriteLine("you are not eligible ");
            }

            int marks = 33;
            if(marks >= 33)
            {
                Console.WriteLine("you are pass");
            }
            else
            {
                Console.WriteLine("you are fail");
            }
        }
    }
}
