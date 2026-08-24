using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Example
{
    public class MethodsExample
    {

        public void Method1()
        {
            Console.WriteLine("hello world"); 
        }
        public void Parameters(string name)
        {
            Console.WriteLine("hello {0}" , name );
        }

        public void Parameters2(int a,int  b)
        {
            Console.WriteLine(a + b);
        }

        public int ReturnType(int a , int b )
        {
            int sum = a + b;
            return sum; 
        }

        public void OptionalParameters(string name = "rial" )
        {
            Console.WriteLine("name {0} ", name);
        } 

        public void NamedParameter(string name , int age )
        {
            Console.WriteLine($"hello every one my name is : {name}  and i am {age} years old ");
        }

        public void MethodOverloading( int a  , int b )
        {
            Console.WriteLine(a + b);

        }
        public void MethodOverloading( int a  , int b , int c)
        {
            Console.WriteLine(a + b + c );

        }


    }
}
