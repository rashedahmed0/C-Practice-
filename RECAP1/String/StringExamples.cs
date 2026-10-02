using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.RECAP1.String
{
    internal class StringExamples
    {
        internal void StringExample1()
        {
            string name = "Rial";
            Console.WriteLine("name : " + name);
            int nameLenght = name.Length;
            Console.WriteLine("nameLenght : " + nameLenght);
            string UpperCaseName = name.ToUpper();
            Console.WriteLine("UpperCaseName : " + UpperCaseName);
            string LowerCaseName = name.ToLower();
            Console.WriteLine("LowerCaseName : " + LowerCaseName);

            int indexOFR = name.IndexOf("a");
            Console.WriteLine(indexOFR);


            bool ContainesR = name.Contains("R");
            Console.WriteLine("Contains 'r' : " + ContainesR);

            string replaceName = name.Replace("Rial", "Rashed");
            Console.WriteLine("replace name is : " + replaceName);

            bool startName = name.StartsWith("R");
            Console.WriteLine("Starts with 'R' : " + startName);

            bool endName = name.EndsWith("l");
            Console.WriteLine("Ends with 'l' : " + endName);

            string song = "     amr sonar bangla ami tomay valobashi   ";
            Console.WriteLine(song);
            Console.WriteLine(song.Trim());
            string subSong = song.Substring(5, 16);
            Console.WriteLine(subSong);


            string[] splitsSong = song.Split(" ");

            foreach (string word in splitsSong)
            {
                Console.WriteLine(word);
            }

            //StringBuilder sb = new StringBuilder();
            //sb.AppendLine("this is first appendchild line ");
            //sb.AppendLine("this is second appendchild line ");
            //Console.WriteLine(sb);


            StringBuilder sb = new StringBuilder("hello");
            sb.Append("world ");
            sb.Insert(0,"! ");
            sb.Replace("world " ," c#");
            Console.WriteLine(sb);

        }
    }
}
