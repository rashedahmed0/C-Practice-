using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Basic.Instance_And_Static_Practice
{
    public class StudentResult
    {
        //instance  

        public string Name;
        public int Bangla;
        public int English;
        public int Math;



        //Static 
        static string  SchoolName = "Ideal college";



        public void Accept(string Name, int Bangla, int English, int Math)
        {
            this.Name = Name;
            this.Bangla = Bangla;
            this.English = English;
            this.Math = Math;
        }

        public void Display()
        {
            int total = Bangla + English + Math;
            int agerage = total / 3;

            Console.WriteLine(SchoolName);
            Console.WriteLine(Name);
            Console.WriteLine("total " + total);
            Console.WriteLine("agerage " + agerage);
            if(agerage >= 80)
            {
                Console.WriteLine("A+");
            }
            else if (agerage >= 70 && agerage < 80)
            {
                Console.WriteLine("A");
            }
            else if (agerage >= 60 && agerage < 70)
            {
                Console.WriteLine("A-");
            }
            else if (agerage >= 33 && agerage < 60)
            {
                Console.WriteLine("Pass");
            }

        }

        public int Roll; 
        public int Fee;

        public void AcceptFR(int roll , int fee)
        {
            this.Roll = roll;
            this.Fee = fee; 
        }
        public void DisplayFR()
        {
            Console.WriteLine("roll is : {0} . fee is : {1}" ,Roll , Fee ); 
        }


        




    }

}
