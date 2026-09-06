using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Problem_Solving.List
{
    public class List
    {
        public void ListExample()
        {
            List<int> numbers = new List<int>();

            // Add 
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            // count 
            Console.WriteLine("numbers count is {0}" , numbers.Count);

            numbers.Remove(2);

            // Index 
            int firstIndexNubmer = numbers[0];
            Console.WriteLine("First index number is {0}" , firstIndexNubmer);


            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }




            Console.WriteLine("numbers {0} count is {1}" , numbers[0] , numbers.Contains(1));
            numbers.Clear();
            Console.WriteLine("After clearing, numbers count is {0}" , numbers.Count);
        } 

        public void listExample1()
        {
            List<string> names = new List<string>();
            names.Add("Rial");
            names.Add("Ahmed");
            names.Add("Rashed"); 
            names.Add("Ahommod");


            // count 
            Console.WriteLine("Names count is {0}", names.Count);

            //index 
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);

            names.Sort(); 
            foreach(string name in names)
            {
                Console.WriteLine("after sort : " + name);
            }

            names.Remove("Rashed");
            foreach (string name in names)
            {
                Console.WriteLine("after  remove : " + name);
            }


            names.RemoveAt(0);
            names.Reverse();
            foreach (string name in names)
            {
                Console.WriteLine("after removeat : " + name);
            }
            Console.WriteLine(names.Contains("Rashed"));
            Console.WriteLine(names.Contains("Rial"));
            Console.WriteLine(names.IndexOf("Rial"));




        }
    }
}
