using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Problem_Solving.Enum
{
    public class EnumTP
    {
        enum Gender
        {
            Male,
            Female,
            Other

        }

        enum Status
        {
            Approve = 1,
            Reject = 2,
            Pending = 3
        }

        public void EnumTPExample()
        {





            //string input = "Approve";
            //if (System.Enum.TryParse<Status>(input, out Status status))
            //{
            //    Console.WriteLine("Status is : " + status);

            //}
            //else
            //{
            //    Console.WriteLine("Invalid status.");
            //}

                //string input = "Male";
                //if (System.Enum.TryParse<Gender>(input, out Gender gender))
                //{
                //    Console.WriteLine("Gender is : " + gender);
                //}
                //else
                //{
                //    Console.WriteLine("Invalid gender.");
                //}
            }
           
    }
}
