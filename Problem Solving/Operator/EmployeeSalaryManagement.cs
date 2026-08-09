using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ConsoleApp1.Problem_Solving.Operator
{
    public class EmployeeSalaryManagement
    {
        string EmployeeName ,EmployeeID ,BasicSalary ,Bonus ,OvertimeHours ,OvertimeRate ,TaxPercentage ;

        public void AcceptEployeeInfo()
        {
            Console.WriteLine("Enter the Employee Name : ");
            EmployeeName = Console.ReadLine();
            Console.WriteLine("Enter the Employee ID : ");
            EmployeeID = Console.ReadLine();
            Console.WriteLine("Enter the Basic Salary : ");
            BasicSalary = Console.ReadLine();
            Console.WriteLine("Enter the Bonus : ");
            Bonus = Console.ReadLine();
            Console.WriteLine("Enter the Overtime Hours : ");
            OvertimeHours = Console.ReadLine();
            Console.WriteLine("Enter the Overtime Rate : ");
            OvertimeRate = Console.ReadLine();
            Console.WriteLine("Enter the Tax Percentage : ");
            TaxPercentage = Console.ReadLine();

        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine("Employee Name : " + EmployeeName);
            Console.WriteLine("Employee ID : " + EmployeeID);
            Console.WriteLine("Basic Salary : " + BasicSalary);
            Console.WriteLine("Bonus : " + Bonus);
            Console.WriteLine("Overtime Hours : " + OvertimeHours);
            Console.WriteLine("Overtime Rate : " + OvertimeRate);
            Console.WriteLine("Tax Percentage : " + TaxPercentage);
        }
        public void CalculateEmployeeSalary()
        {
            int empId = int.Parse(EmployeeID);
            double salary = Convert.ToDouble(BasicSalary);
            double bonus = double.Parse(Bonus);
            int overTimeHours = int.Parse(OvertimeHours);
            double overtimeRate = double.Parse(OvertimeRate);

            double overtimePay = overtimeRate * overTimeHours;
            Console.WriteLine(overtimePay);

            double grossSalary = salary + bonus + overtimePay;
            Console.WriteLine("Gross Salary : " + grossSalary);

            double taxPercentage = double.Parse(TaxPercentage);
            double taxAmount = (taxPercentage / 100) * grossSalary;
            Console.WriteLine("Tax Amount : " + taxAmount);

            double annualSalary = 12 * (grossSalary - taxAmount);
            Console.WriteLine("Annual Salary : " + annualSalary);
            double netsalary = salary - taxAmount;
            
            string salaryGrade = netsalary  > 100000 ? "high" :
                netsalary >50000 && netsalary < 100000 ? "medium" :
                netsalary < 50000 ? "low" : "invalid";
            Console.WriteLine("Salary Grade : " + salaryGrade);

            bool isTaxEligible = netsalary > 50000 ? true : false; 
            Console.WriteLine("Is Tax Eligible : " + isTaxEligible);
        }
    }
}
