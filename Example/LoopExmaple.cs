using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Example
{
    public  class LoopExmaple
    {
//for
//for (initialization; condition; increment/decrement)
//{
//    // code
//}

       public void ForExmaple()
        {
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void WhileLoopExample()
        {
            int i = 1;
            while(i <= 5)
            {
                Console.WriteLine(i);
            i++;
            }
        }

        public void DoWhileLoopExample()
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 5);
        }

        public void ForEachLoopExample()
        {
            string[] names = { "rashed", "rial", "ahmed", "pathan" };
            foreach(string name in names){
                Console.WriteLine(name);
            }
        }

        public void NestedLoopExample()
        {
            for(int i = 5; i< 6; i++)
            {
                for(int j = 1; j < 10; j++)
                {
                    Console.WriteLine("{0} X {1} = {2}", i, j , i * j );

                }
            }
        }

        public void ContinueLoopExample()
        {
            for(int i = 1; i < 10; i ++)
            {
                if(i == 6)
                {
                    continue; 
                }
                Console.WriteLine(i);
            }
        }
         
        public void BreakLoopExample()
        {
            for(int i = 1; i < 10; i++)
            {
                if(i == 6)
                {
                    break; 
                }
                Console.WriteLine(i);
            }
        }
    }
}
