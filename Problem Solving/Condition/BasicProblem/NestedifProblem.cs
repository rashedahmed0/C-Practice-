using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Problem_Solving.Condition.BasicProblem
{
    public class NestedifProblem
    {
        public void ATMWithdrawal()
        {
            int pin = 1234;
            int suficientBalance = 1000;
            if (pin == 1234) {
                if(suficientBalance > 500)
                {
                    Console.WriteLine("withdra success your balacne id : {0} " , suficientBalance );
                }
                else
                {
                    Console.WriteLine("withdra Failed your balacne id : {0} \" , suficientBalance ");
                }
            }
            else
            {
                Console.WriteLine("withdra Failed your balacne id : {0} \" , suficientBalance ");
            }
        }


        public void JobEligibility()
        {
            int age = 26;
            string education = "bachelor";
            int experience = 2;
            if (age >= 18)
            {
                if(education == "bachelor")
                {
                    if(experience >1)
                    {
                        Console.WriteLine("Your are eligible for job Your age {0} , educaiotn {1} , experience {2} ", age, education, experience);
                    }
                    else
                    {
                        Console.WriteLine("Your are not eligible for job Your age {0} , educaiotn {1} , experience {2} ", age, education, experience);
                    }
                }
                else
                {
                    Console.WriteLine("Your are not eligible for job Your age {0} , educaiotn {1} , experience {2} ", age, education, experience);
                }
            }
            else
            {
                Console.WriteLine("Your are not eligible for job Your age {0} , educaiotn {1} , experience {2} ", age, education, experience);
            }
        }


        public void OnlineShopping()
        {
            int productPrice = 500 ;
            bool ismember = true;
            string coupon = "2213";
            if(productPrice > 499)
            {
                if(ismember == true)
                {
                    if (coupon == "2213")
                    {
                        Console.WriteLine("you got discount ");
                    }
                    else
                    {
                        Console.WriteLine("you got discount ");
                    }
                }
                else
                {
                    Console.WriteLine("you got discount ");
                }
            }
            else
            {
                Console.WriteLine("you got discount ");
            }
        }



    }
}
