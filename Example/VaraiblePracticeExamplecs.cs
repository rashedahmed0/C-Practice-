using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Xml.Serialization;

namespace ConsoleApp1.Example
{
    public class VaraiblePracticeExamplecs
    {
      public void VariablePractice()
        {
            // DataType variableName = value ; 
            int age = 26;
            string name = "Rial Ahmed";
            bool isStudent = true;
            bool isMarried = false;
            char star = '*';
            double salary = 12000.00;
            float height = 5.6f;
            decimal price = 100.50m;


            Console.WriteLine("age is ; " + age);
            Console.WriteLine("name is : " + name);
            Console.WriteLine("is he strudnet : " + isStudent);
            Console.WriteLine("star is : " + star);
            Console.WriteLine("salary is : " + salary);
            Console.WriteLine("height is : " + height);
            Console.WriteLine("price is : " + price);


        }

        public void TypeConvertion()
        {
            //string to double
            string strNubmer1 = "2.5";
            double doubleNubmer1 = double.Parse(strNubmer1);
            Console.WriteLine("string to double : " + doubleNubmer1);
            int intNubmer1 = (int)doubleNubmer1; //explicit  conversion from double to int
            Console.WriteLine("double to int : " + intNubmer1);
            int intNubmer2 = Convert.ToInt32(doubleNubmer1); //explicit conversion from double to int


            decimal price = 99.99m;
            double amount = (double)price; //explicit conversion from decimal to double
            Console.WriteLine("decimal to double : " + amount);
            double price2 = 99.20;
            decimal amount2 = (decimal)price2; //explicit conversion from double to decimal
        }

       

    }
}
