using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.RECAP1.Loop
{
    internal class Loop
    {
        internal void forExample()
        {
            for(int i = 0; i <= 5; i ++)
            {
                int element = i;
                Console.WriteLine(element);

                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(i);
                }

            }

        }
            internal void whileExamples()
        {
            int i = 1;
            while (i > 5)
            {
                Console.WriteLine(i);
                i++;

            }



        }
        internal void doWhileExample()
        {
            int i = 0; do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 10);
        }

        internal void ForeachExamples()
        {
            int[] ages = { 23, 24, 22, 21 };
            int maxAge = 0;
            foreach(int age in ages)
            {
                if(age > maxAge)
                {
                    maxAge = age; 
                }


                Console.WriteLine("courrentages : " + age );
                Console.WriteLine("5 yaers later ages : " +( age + 5 ));
            }
            Console.WriteLine("max ages ");
        }
        internal void NestedLoop()
        {
            for(int i =0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    Console.WriteLine("i : {0} , j : {1}" , i  , j );
                }
            }
        }

        internal void BreakContinue()
        {
            for(int i = 0; i < 5; i++)
            {
                if(i == 3)
                {

                    break; 
                }
                Console.WriteLine(i );
            }

            for(int j = 0; j < 5; j++)
            {
                if(j == 3)
                {
                    continue;
                }
                Console.WriteLine(j); 
            }
        }


    }
}
