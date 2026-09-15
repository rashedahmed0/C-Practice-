using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Basic.Instance_And_Static_Practice
{
    public class InstanceAndStaticExample
    {

        //  static
        public static string campusName = "nation University";

        // intance 
        public string studentName ;
        public int studentRoll ;

        public void StudentAccept(string name , int roll)
        {
            this.studentName = name;
            this.studentRoll = roll; 

        }

        public void StudentDisplay()
        {
            Console.WriteLine("Campus name is : {0} , Student Name is : {1} and roll is : {2}" , campusName , studentName , studentRoll);
        } 



        public static string  CompnaryName = "techno developer thrillls ";

        public string employeeName;
        public string employeeDesignation; 

        public void EmployeeAccepct(string name , string designation)
        {
            this.employeeName = name;
            this.employeeDesignation = designation; 
             
        }
        public void EmployeeDisplay()
        {
            Console.WriteLine("CompanyName is : {0} , EmployeeNmae : {1} and EmployeeDesignation is : {2}" , CompnaryName , employeeName , employeeDesignation);
        }


    }
}
