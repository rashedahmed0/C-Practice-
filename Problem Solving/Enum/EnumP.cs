using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Problem_Solving.Enum
{
    public class EnumP
    {
        enum Gender
        {
            Male ,
            Female ,
            Other 

        }
        enum Status
        {
            Approve = 1 ,
            Reject = 2,
            Pending = 3
        }

        enum Days
        {
            Saturday ,
            Sunday ,
            Monday,
            Tuesday,
            Wednesday,

            Thursday,
            Friday,

        }
        public void EnumpExmaple()
        {
            //string input = "Thursday";
            //Days day = System.Enum.Parse<Days>(input);
            //Console.WriteLine(day);


            //string input = "Approve";
            //Status status = System.Enum.Parse<Status>(input);
            //Console.WriteLine("Status is : " + status);

            //string input = "Male";
            //Gender gender = System.Enum.Parse<Gender>(input);
            //Console.WriteLine("Gender is : " + gender);
        }
    }
}
