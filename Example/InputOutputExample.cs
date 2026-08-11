using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Example
{
    public class InputOutputExample
    {
        public void OutputExample()
        {
            //Console.Write("hello ");
            //Console.Write("world \n");
            //Console.WriteLine("hello \nworld ");


            //Console.Write("name : ");
            //Console.Write("rashed ");
            //Console.Write("age : ");
            //Console.Write("25 ");


            int age = 25;
            string name = "Rashed";
            //Console.WriteLine("Name : {0} , age : {1} " , name , age );
            Console.WriteLine($"Name : {name} , Age : {age}");

        
        }
    }
}
