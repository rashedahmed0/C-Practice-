using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ConsoleApp1.Example
{
    public class VaraiblePracticeExamplecs
    {
        public void VariablePractice()
        {
            int age = 10;
            double height = 5.6;
            string name = "Rial ahmed";
            bool isStudent = true;
            decimal salary = 12000.00m;
            char star = '*';

            Console.WriteLine(age + name + height + isStudent + salary + star);

        }


        //Problem 1: Student Result
        string math, english;

        public void AcceptMarks()
        {
            Console.WriteLine("enter the math Marks : ");
            math = Console.ReadLine();

            Console.WriteLine("enter the english Marks");
            english = Console.ReadLine();
        }



        public void MarksVariablePractice()
        {
            string mathStr = math;
            string englishStr = english;

            int mathMarks = int.Parse(mathStr);
            int englishMarks = Convert.ToInt32(englishStr);

            int avergeMarks = (mathMarks + englishMarks) / 2;
            Console.WriteLine("averge of math and english is : " + avergeMarks);

            int totalMarks = mathMarks + englishMarks;
            Console.WriteLine("TOTAL number of math and english is : " + totalMarks);

            int differenceMarks = englishMarks - mathMarks;
            Console.WriteLine("Average between math and englsih is : " + differenceMarks);
        }



        //Problem 2: Employee Salary Calculation
        string salary, tax, bonous;

        public void AcceptSalary()
        {
            Console.WriteLine("enter your Salary : ");
            salary = Console.ReadLine();
            Console.WriteLine("enter your Tax : ");
            tax = Console.ReadLine();
            Console.WriteLine("enter your Bonous : ");
            bonous = Console.ReadLine();
        }

        public void EmployeeSalaryCalculation()
        {
            string salaryStr = salary;
            int salaryInt = int.Parse(salaryStr);
            string taxStr = tax;
            int taxInt = Convert.ToInt32(taxStr);
            string bonousStr = bonous;
            int bonousInt = Convert.ToInt32(bonousStr);

            int grossSalary = salaryInt + bonousInt;
            Console.WriteLine("gross salary is : " + grossSalary);
            int netSalary = grossSalary - taxInt;
            Console.WriteLine("net salary is : " + netSalary);
        }


        //Problem 3: Shopping Bill

        string rice, oil, sugar;
       
        public void AcceptShoppingBill()
        {
            Console.WriteLine("Enter the Rice bill : ");
            rice = Console.ReadLine();
            Console.WriteLine("Enter the Oil bill : ");
            oil = Console.ReadLine(); 
            Console.WriteLine("Enter the Suger bill : ");
            sugar = Console.ReadLine();

        }

        public void ShoppingBill()
        {
            string riceStr  = rice; 
            int riceInt = int.Parse(riceStr);

            string oilStr = oil;
            int oilInt = Convert.ToInt32(oilStr);

            string sugarStr = sugar;
            int sugarInt = Convert.ToInt32(sugarStr);

            int total = riceInt + oilInt + sugarInt;

            int vat10 = (total * 10) / 100;
            int bill = total = vat10;

            Console.WriteLine("total price is : " + total);
            Console.WriteLine("vat is : " + vat10);
            Console.WriteLine("total bill is : " + bill);

        }

        //Problem 4: Age Calculator

        string BithYear; 
        public void AcceptBirthYear()
        {
            Console.WriteLine("Enter your Birth Year : ");
            BithYear = Console.ReadLine();
        }
        public void AgeCalculator()
        {
            string birthYearStr = BithYear;
            int birthYearInt = int.Parse(birthYearStr);
            int currentYear = 2026;
            int age = currentYear - birthYearInt;
            Console.WriteLine("Your Age is : " + age);
        }

    }
}
