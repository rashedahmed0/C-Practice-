using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ConsoleApp1.Problem_Solving.Variable
{
    public class EmployeeInformationSystem
    {
        string Name, EmployeeID, Age, Salary, Bonus, Department, Gender, IsPermanent, WorkingHours, PhoneNumber;
        public void AcceptEmployeeInformation()
        {
            Console.WriteLine("Enter Employee Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter EmployeeID: ");
            EmployeeID = Console.ReadLine();
            Console.WriteLine("Enter Employee Age: ");
            Age = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary: ");
            Salary = Console.ReadLine();
            Console.WriteLine("Enter Employee Bonus: ");
            Bonus = Console.ReadLine();
            Console.WriteLine("Enter Employee Department: ");
            Department = Console.ReadLine();
            Console.WriteLine("Enter Employee Gender: ");
            Gender = Console.ReadLine();
            Console.WriteLine("Enter Employee IsPermanent: ");
            IsPermanent = Console.ReadLine();
            Console.WriteLine("Enter Employee WorkingHours: ");
            WorkingHours = Console.ReadLine();
            Console.WriteLine("Enter Employee PhoneNumber: ");
            PhoneNumber = Console.ReadLine();


        }
        public void DisplayEmployeeInformation()
        {
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("EmployeeID: " + EmployeeID);
            Console.WriteLine("Employee Age: " + Age);
            Console.WriteLine("Employee Salary: " + Convert.ToInt32(Salary));

            Console.WriteLine("Employee Bonus: " + Bonus);
            Console.WriteLine("Employee Department: " + Department);
            Console.WriteLine("Employee Gender: " + Gender);
            Console.WriteLine("Employee IsPermanent : " + IsPermanent);
            Console.WriteLine("Employee WorkingHours: " + WorkingHours);
            Console.WriteLine("Employee PhoneNumber: " + PhoneNumber);




        }

        public void SalaryCalculation()
        {
            int salary = int.Parse(Salary);
            int bonus = int.Parse(Bonus); 
            int netsalary = salary + bonus;
            int grosssalary = netsalary - (netsalary * 10 / 100);
            Console.WriteLine("Net Salary: " + netsalary);
            Console.WriteLine("Gross Salary: " + grosssalary);

        }
    }
}