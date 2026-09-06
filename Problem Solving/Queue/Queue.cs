using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Problem_Solving.Queue
{
    public class QueueExmaple
    {
        public void QueueProblem()
        {
            Queue<int> numbers = new Queue<int>();


            // add 
            numbers.Enqueue(5);
            numbers.Enqueue(23);
            numbers.Enqueue(34);
            numbers.Enqueue(12);

            Console.WriteLine(numbers.Count);

            //first remove 
            Console.WriteLine("peek number : " +  numbers.Peek());

            numbers.Dequeue();
            
            foreach (int number in numbers)
            {
                Console.WriteLine("after remove : " + number);
            }

            Console.WriteLine(numbers.Contains(12));

            numbers.Clear();

                  Console.WriteLine("after clear : " + numbers.Count);


        }
    }
}
