using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp1.Syntax.Variable_Syntax
{
    public class Variable
    {
        public void VariableSyntax()
        {
            //dataType variableName = value;

            int age = 26;
            string name = "Rial Ahmed";
            bool isStudent = true;

            Console.WriteLine(age);
            Console.WriteLine(name);
            Console.WriteLine(isStudent);


            //var variableName = value;
            var city = "dhaka ";
            var salary = 12000;

        }

        public void ConstantSyntaxt()
        {
            //const dataType constantName = value;

            const double pi = 3.1416;
            Console.WriteLine(pi);



        }
        public void PrimitiveDatatype()
        {
            //Primitive Data Types
            //int, float, double, char, bool, string ,decimal 
            int age = 26;
            float height = 5.6f;
            double salary = 12000.00;
            char star = '*';
            bool isStudent = true;
            string name = "rial ahmed";

            Console.WriteLine(age);
            Console.WriteLine(height);
            Console.WriteLine(salary);
            Console.WriteLine(star);
            Console.WriteLine(isStudent);
            Console.WriteLine(name);

        }

        public void Implicity()
        {
            int number = 1000;
            double value = number;
            Console.WriteLine(value);
            Console.WriteLine(number);
        }
        public void Explicity()
        {
            double number = 99.99;
            int value = (int)number;
            Console.WriteLine(number);
            Console.WriteLine(value);
        }

        public void Parse()
        {
            string strNum = "100";
            int num = int.Parse(strNum);
            Console.WriteLine(strNum);
            Console.WriteLine(num);
        }

        public void Convertp()
        {
            int number = 100;
            string text = "100.55";
            double value = Convert.ToDouble(text);
           var intvalue = Convert.ToInt32(value);
            
            Console.WriteLine(intvalue.GetType());

        }
    }
}
