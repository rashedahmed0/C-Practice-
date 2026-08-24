using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Example
{
    public class StringEXamples
    {
        public void StringExample()
        {
            string name = "Rial Ahmed";
            string flowers = "rose , lili , waterlili";
            string[] result = flowers.Split(","); 
            string email = "rialahmed@gmail.com";
            Console.WriteLine(name);
            Console.WriteLine(name.Length);
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(email);
            Console.WriteLine(email.Contains("@"));
            Console.WriteLine(email.Contains("#"));
            Console.WriteLine(email.StartsWith("Rial"));
            Console.WriteLine(email.StartsWith("ial"));
            Console.WriteLine(email.EndsWith("com"));
            Console.WriteLine(name.Replace("Rial" , "Rashed"));
            Console.WriteLine(result);
            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);
            Console.WriteLine(result[2]);

            foreach(string flower in result)
            {
                Console.WriteLine(flower);
            }

            string profesion = "  developer  ";
            Console.WriteLine(profesion.Trim());
            Console.WriteLine(name.Substring(0,4));


            StringBuilder sb = new StringBuilder();
            sb.AppendLine("name : rashed ahmed pathan");
            sb.AppendLine("age : 26");
            sb.AppendLine("isStudent : ture ");
            sb.AppendLine("ismarid");
            Console.WriteLine(sb);

        }
    }
}
