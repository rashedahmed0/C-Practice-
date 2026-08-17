using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Problem_Solving.Condition.BasicProblem
{
    public class SwitchProblem
    {
        public void TrafficSignal()
        {
            int traffic = 0;

            switch (traffic)
            {
                case 0:
                    Console.WriteLine("Green signal "); 
                        break;
                case 1:
                    Console.WriteLine("yeollow signal ");
                    break;
                case 2:
                    Console.WriteLine("Red signal ");
                    break;
            }
        }
        
        public void MenuDrivenProgram()
        {
            int MenuDriven = 1; 

            switch (MenuDriven)
            {
                case 0:
                    Console.WriteLine(" Check Balance");
                    break;
                case 1:
                    Console.WriteLine("Deposit");
                    break; 
                case 2:
                    Console.WriteLine("Withdraw");
                    break;
                default:
                    Console.WriteLine("Exit");
                    break;
            }
        }

        public void FoodOrderingSystem()
        {
            int food = 0;
            switch (food)
            {
                case 0:
                    Console.WriteLine("burger");
                    break;
                case 1:
                    Console.WriteLine("pizza");
                    break;
                case 2:
                    Console.WriteLine("coffee");
                    break;
                    default:
                    Console.WriteLine("Rice");
                    break; 
            }
        }
    }
}
