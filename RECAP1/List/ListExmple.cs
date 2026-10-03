using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.RECAP1.List
{
    internal class ListExmple
    {
        internal void liExamples()
        {
            List<int> Ages = new List<int>();
            Ages.Add(23);
            Ages.Add(24);
            Ages.Add(25);
            Ages.Add(26);
            Ages.Remove(23);
            Ages.RemoveAt(Ages.Count - 1);
            Ages.Insert(0,100);
            Ages.Sort();
            Ages.Reverse();
            foreach(int age in Ages)
            {
                Console.WriteLine(age);
                
            }
            int listCount = Ages.Count;
            Console.WriteLine("List Count : " + listCount);




            List<string> Names = new List<string>();
            Names.Add("Rashed");
            Names.Add("Ahmed");
            Names.Add("Rial");
            Names.Add("Ahommod");

            Names.Remove("Rashed");
            Names.RemoveAt(Names.Count - 1);

            Names.Sort();
            Names.Reverse();

            foreach (string name in Names)
            {
                Console.WriteLine(name);
            } 


        }

    }
}
