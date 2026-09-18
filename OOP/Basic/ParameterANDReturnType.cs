using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ConsoleApp1.OOP.Basic
{
    public class ParameterANDReturnType
    {
        // no parameter / no return type 
        // no parameter / return type 
        //  parameter / return type 
        //  parameter / no return type 

        public void Square (){
            int a = 2;
            Console.WriteLine(a*a);

            }

        public int Square1()
        {
            int a = 2;
            return a *a;
        }

        public void Square2(int a ) {
            Console.WriteLine(a*a);
        }

        public int Square3(int a )
        {
            return a * a; 
        }
    }

}
