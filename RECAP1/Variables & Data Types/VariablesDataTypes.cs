using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.RECAP1.Variables___Data_Types
{
    internal class VariablesDataTypes
    {
        internal void StudentInformation()
        {
            string name = "rial ";
            int age = 25;
            float cgpa = 3.35f;
            string department = "CSE";
            bool isGraduated = false;

            Console.WriteLine("name : {0} " , name);
            Console.WriteLine("age : {0} ", age);
            Console.WriteLine("cgpa : {0} ", cgpa);
            Console.WriteLine("department : {0} ", department);
            Console.WriteLine("isGraduated : {0} ", isGraduated);

            Console.WriteLine("name : {0} " , name.GetType());
            Console.WriteLine("age : {0} ", age.GetType());
            Console.WriteLine("cgpa : {0} ", cgpa.GetType());
            Console.WriteLine("department : {0} ", department.GetType());
            Console.WriteLine("isGraduated : {0} ", isGraduated.GetType());

        }
        internal void ProductPrice()
        {
            string productName = "pen";
            int ProductPrice = 10;
            int quantity = 5;
            int toalPrice = ProductPrice * quantity;
            Console.WriteLine("product Name is : " + productName);
            Console.WriteLine("product Price is : " + ProductPrice);
            Console.WriteLine("quantity is : " + quantity);
            Console.WriteLine("total Price is : " + toalPrice);
        }

        internal void tepmeratureConversion()
        {
            int c = 25;
            float f = (float)(c * 9 /5 ) + 32 ;
            Console.WriteLine("temperature in celsius is : " + c);
            Console.WriteLine("temperature in Fahrenheit is : " + f);
        }

        internal void typeConversion()
        {
            string str = "100";
            int num1 = Convert.ToInt32(str);
            int num2 = int.Parse(str) ;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }

        internal void IMplixit()
        {
            int numint = 100;
            double numdouble = numint;
            float numfloat = numint; 
            decimal numdecimal = numint;

            double numdoubleFloat = numfloat;
            double numd = 54323.33;
            Console.WriteLine("Implicit int to double  conversion: {0}", numdouble);
            Console.WriteLine("Implicit int to float  conversion: {0}", numfloat);
            Console.WriteLine("Implicit int to decimal  conversion: {0}", numdecimal);
        }

        internal void EXplicit()
        {
            decimal salaryDecimal = 12000;
            int salaryInt = (int)salaryDecimal; 
            double salaryDouble = (double)salaryDecimal;
            float salaryFloat = (float)salaryDecimal; 

            Console.WriteLine("Explicit decimal to int conversion: {0}", salaryInt);
            Console.WriteLine("Explicit decimal to double conversion: {0}", salaryDouble);
            Console.WriteLine("Explicit decimal to float conversion: {0}", salaryFloat);

            double doubleValue = 123.22;
            float floatCalue = (float)doubleValue;
            int intValue = (int)doubleValue;
            Console.WriteLine("Explicit double to int conversion: {0}", intValue);  




        }
    }
}
