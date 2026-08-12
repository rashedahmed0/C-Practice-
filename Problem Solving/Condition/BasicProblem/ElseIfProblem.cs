using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Problem_Solving.Condition.BasicProblem
{
    public class ElseIfProblem
    {
        public void StudentGrade()
        {
            int marks = 50;
            if (marks >= 80)
            {
                Console.WriteLine("you got A+ your number is : {0}", marks);
            }
            else if (marks >= 70 && marks < 79)
            {
                Console.WriteLine("you got A your number is : {0}", marks);
            }
            else if (marks >= 60 && marks < 69)
            {
                Console.WriteLine("you got A- your number is : {0}", marks);
            }
            else if (marks >= 50 && marks < 59)
            {
                Console.WriteLine("you got B your number is : {0}", marks);
            }
            else if (marks >= 40 && marks < 49)
            {
                Console.WriteLine("you got B your number is : {0}", marks);
            }
            else if (marks > 33 && marks < 39)
            {
                Console.WriteLine("you got C your number is : {0}", marks);
            }
            else
            {
                Console.WriteLine("you are Fail  your number is : {0}", marks);
            }
        }

        public void TemperatureStatus()
        {
            int temprature = 80;
            if (temprature < 10)
            {
                Console.WriteLine("very cold");
            }
            else if (temprature >= 11 && temprature <= 20)
            {
                Console.WriteLine("cold");
            }
            else if (temprature >= 21 && temprature <= 30)
            {
                Console.WriteLine("hot");
            }
            else if (temprature >= 31 && temprature <= 40)
            {
                Console.WriteLine("very hot");
            }
            else
            {
                Console.WriteLine("kutta mora gorom");
            }


        }

        public void ShoppingDiscount()
        {
            int shoppingBill = 5000;
            if (shoppingBill >= 5000)
            {
                int finalBill = shoppingBill - (shoppingBill * 20 / 100);
                Console.WriteLine($"final bill After discount is : {finalBill}");
            }
            if (shoppingBill >= 2000 && shoppingBill <= 4999)
            {
                int finalBill = shoppingBill - (shoppingBill * 10 / 100);
                Console.WriteLine($"final bill After discount is : {finalBill}");
            }
            if (shoppingBill >= 1000 && shoppingBill <= 1999)
            {
                int finalBill = shoppingBill - (shoppingBill * 5 / 100);
                Console.WriteLine($"final bill After discount is : {finalBill}");
            }
        }

        public void EmployeeSalaryGrade()
        {
            int salary = 10000;
            if(salary <= 10000)
            {
                Console.WriteLine("intern");
            }
            else if (salary > 10000 && salary <= 18000)
            {
                Console.WriteLine("junior developer");
            }
            else if (salary > 18000 && salary <= 28000)
            {
                Console.WriteLine("midlevel  developer");
            }
            else if (salary > 28000 && salary <= 58000)
            {
                Console.WriteLine("senior  developer");
            }
            else 
            {
                Console.WriteLine("Executive director ");
            }

        }

        public void BMICategory()
        {
            int weight = 76;
            if(weight  > 80)
            {
                Console.WriteLine("you are fat");
            }
            else if (weight >= 60 && weight <= 79)
            {
                Console.WriteLine("your are mideum ");
            }
            else
            {
                Console.WriteLine("your are thin");
            }
        }

        public void ElectricityBill()
        {
            int totalUnit = 100;
            if(totalUnit > 300)
            {
                int unitPrice = 17;
                int totalUnitPrice = totalUnit * unitPrice;
                Console.WriteLine(totalUnitPrice);
            }
            else if (totalUnit > 200 && totalUnit < 300)
            {
                int unitPrice = 15;
                int totalUnitPrice = totalUnit * unitPrice;
                Console.WriteLine(totalUnitPrice);
            }
            else if (totalUnit > 100 && totalUnit < 200)
            {
                int unitPrice = 13;
                int totalUnitPrice = totalUnit * unitPrice;
                Console.WriteLine(totalUnitPrice);
            }
            else 
            {
                int unitPrice = 10;
                int totalUnitPrice = totalUnit * unitPrice;
                Console.WriteLine(totalUnitPrice);
            }
        }


    }
}
