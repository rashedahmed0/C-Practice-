using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Problem_Solving.Dictionary
{
    public class DictionaryExample
    {


        public void DictionaryProblemOne()
        {
            
        }



        public void DictionaryMethod()
        {
            Dictionary<int , string> students = new Dictionary<int, string>();
            students.Add(101 , "rashed");
            students.Add(102, "ahmed");
            students.Add(103, "pathan");

            Console.WriteLine("total Student : " + students.Count);
            Console.WriteLine("first Sutendt : " + students[101]); 
            Console.WriteLine("first Sutendt : " + students[102]);

            students[101] = "Rial"; // Update the value for key 101

            students.Remove(102); // Remove the entry with key 102

            if (students.ContainsKey(102))
            {
                Console.WriteLine("Student found with key 102");
            }
            else
            {
                Console.WriteLine("Student not found with key 102");
            }

            if (students.ContainsValue("Rial")) 
            {
              Console.WriteLine("Student found with value Rial");
            }
            else
            {
                Console.WriteLine("Student not found with value Rial");
            }
            foreach (KeyValuePair<int, string> student in students) 

            {
                Console.WriteLine($"ID :{student.Key}" + " Name : {0}" , student.Value);
            }

        }
    }
}
