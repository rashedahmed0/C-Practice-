using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Problem_Solving.Dictionary
{
    public class DictionaryExample
    {
        public void DictionaryMethod()
        {
            Dictionary<int , string> students = new Dictionary<int, string>();
            students.Add(101 , "rashed");
            students.Add(102, "ahmed");

            Console.WriteLine("total Student : " + students.Count);
            Console.WriteLine("first Sutendt : " + students[101]); 
            Console.WriteLine("first Sutendt : " + students[102]);

            students[101] = "Rial"; // Update the value for key 101

        }
    }
}
