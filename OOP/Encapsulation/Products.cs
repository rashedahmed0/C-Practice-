using System;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;

namespace ConsoleApp1.OOP.Encapsulation
{
    internal class Products
    {
        //private Data 
        private int productId; 

        private int productPrice;
        private int productQuantity;
        private int totalPrice;


        //Property
        internal int ProductId { get { return productId; } set { productId = value; } }
        internal int ProductPrice { get { return productPrice; } set { productPrice = value; } }
        internal int ProductQuantity { get{ return productQuantity; } set { productQuantity = value; }  }
        internal int TotalPrice { get{ return totalPrice; } set { totalPrice = value; }  }


        internal void Calculation()
        {
           TotalPrice = ProductPrice * ProductQuantity;

        }
        internal void Display()
        {
            Console.WriteLine("ProductId : " + ProductId);
            Console.WriteLine("ProductPrice : " + ProductPrice);
            Console.WriteLine("ProductQuantity : " + ProductQuantity);
            Console.WriteLine("TotalPrice : " + TotalPrice);
        }


    }
}
