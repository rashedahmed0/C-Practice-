using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Text;

namespace ConsoleApp1.RECAP1.Array
{
    internal class ArrayExamples
    {

        internal void SingleArray()
        {
            int[] ages = { 23, 42, 11, 23 };
            for(int i = 0; i < ages.Length; i++)
            {
                Console.WriteLine(ages[i]);
            }

            string[] names = { "Rashed", "Rial", "himu", "ahmed" };
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);   
            } 

        }

        internal void MultiDimensionalArr()
        {
            int[,] nums =
             {
                {1,3,5,7,9 },
                {2,4,6,8 ,10}
            };
            for(int i = 0; i < nums.GetLength(0); i++)
            {
                for(int j = 0; j < nums.GetLength(1); j++)
                {
                    Console.WriteLine(nums[i,j]);
                }
            }


            int[,] ages =
            {
                {22 , 55 ,77 },
                {11,33,55 }
            };

            for(int a = 0; a < ages.GetLength(0); a++)
            {
                for(int b = 0; b < ages.GetLength(1); b++)
                {
                    Console.WriteLine(ages[a,b]);
                }
            }


            string[,] names =
            {
                {"rial" , "ahmed" },
                {"rashed" , "ahmed" }
            };
            for(int i = 0; i < names.GetLength(0); i++)
            {
                for(int j= 0; j < names.GetLength(1); j++)
                {
                    Console.WriteLine(names[i, j]);
                }

            }
        }


    }
}
