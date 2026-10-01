using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOP.Abstract
{
    internal class Cat : Animal
    {
        
        internal override void Sound()
        {
            Console.WriteLine("cat name {0} . its sound : mew mew " , Name);    
        }

    }
}
