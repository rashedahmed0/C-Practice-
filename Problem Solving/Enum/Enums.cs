using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Problem_Solving.Enum
{
    public class Enums
    {
        enum Gender
        {
            Male,
            female,
            Other
        }
        enum Days
        {
            Saturday,
            Sunday,
            Monday ,
            Tuesday,
            Wednesday,
            Thursday,
            Friday

        }

        enum Status
        {
            Approve = 1,
            Reject = 2,
            pendin = 3
        }
        public void EnumsExample()
        {

            //Gender gender = (int)Gender.Male;
            //Console.WriteLine(gender);


            Console.WriteLine("Enter gender : ");
            string input =  Console.ReadLine();

            if (System.Enum.TryParse<Gender>(input, true , out Gender gender))
            {
                Console.WriteLine("Gender is : " + gender);
            }

                Console.WriteLine((int)Days.Sunday);
            Console.WriteLine((int)Days.Monday);

            Status statusApprove = Status.Approve;
            Console.WriteLine((int)statusApprove);

        }
    }
}
