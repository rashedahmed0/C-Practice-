using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Problem_Solving.TryCatchThrow
{
    internal class TryCatchfinalThrow
    {
        public void TryCatchExample()
        {
            int a = 10;
            int b = 2;
            try
            {
                int resutl = a / b;
                Console.WriteLine("Result: " + resutl);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Console.WriteLine("An error occurred: Division by zero.");
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }
        }
    }
}