using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Example
{
    public class ArrayExample
    {
        public void SingleArray()
        {
            int[] ages = { 23, 44, 62, 33 };
            //Console.WriteLine(age);

           Array.Sort(ages);
            Array.Reverse(ages);
            foreach(int age in ages)
            {
                Console.WriteLine(age);
            }
                Console.WriteLine(Array.IndexOf(ages , 33));
        }

        public void multidimensional() {
            string[,] names =
            {
                {"rial" , "dipti" , "dinar " },
                {"rashed" , "kulsum" , "shahed" }
            };

            //Console.WriteLine(names[0,0] );
            //Console.WriteLine(names[1,0]);
            foreach (string  name in names) {
                //Console.WriteLine(name);
            }

            for(int i =0; i < names.GetLength(0); i++)
            {
                for(int j = 0; j < names.GetLength(1); j++)
                {
                    //Console.WriteLine(names[i, j] + " ");
                }
            }


        }

        public void JaggedArray()
        {
            int[][] numbers =
            {
                new int[] { 1, 2} ,
                new int[] {1,2,3,4} ,
                new int[] {1,3,4}
            };
            //Console.WriteLine(numbers[0][1]);
            //Console.WriteLine(numbers[1][0]);
            //Console.WriteLine(numbers[2][2]);
            
            for(int i = 0; i < numbers.Length; i++)
            {
                for(int j =  0; j < numbers[i].Length; j++)
                {
                    //Console.WriteLine(numbers[i][j] );
                }
            }

        }

    }
}
