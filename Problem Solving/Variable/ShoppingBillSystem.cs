using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ConsoleApp1.Problem_Solving.Variable
{
    public class ShoppingBillSystem
    {
        string CustomerName  ,Discount ,VAT ,IsMember 
            ,InvoiceNumber , Potato, Tomato, Onion, Cucumber, Carrot, 
            Cabbage, Broccoli, Spinach, Lettuce, Cauliflower, 
            Mushroom, Garlic, Ginger, Lemon;

        public void AcceptShoppingBillInformation()
        {
            Console.WriteLine("Enter the Custormer Name : ");
            CustomerName = Console.ReadLine();
            Console.WriteLine("Enter the Discount :");
            Discount = Console.ReadLine();
            Console.WriteLine("Enter the VAT :");
            VAT = Console.ReadLine();
            Console.WriteLine("Enter the IsMember :");
            IsMember = Console.ReadLine(); 
            Console.WriteLine("Enter the InvoiceNumber :");
            InvoiceNumber = Console.ReadLine();
            Console.WriteLine("Enter the Potato :");
            Potato = Console.ReadLine();
            Console.WriteLine("Enter the Tomato :");
            Tomato = Console.ReadLine();
            Console.WriteLine("Enter the Onion :");
            Onion = Console.ReadLine();
            Console.WriteLine("Enter the Cucumber :");
            Cucumber = Console.ReadLine();
            Console.WriteLine("Enter the Carrot :");
            Carrot = Console.ReadLine();
            Console.WriteLine("Enter the Cabbage :");
            Cabbage = Console.ReadLine();
            Console.WriteLine("Enter the Broccoli :");
            Broccoli = Console.ReadLine();
            Console.WriteLine("Enter the Spinach :");
            Spinach = Console.ReadLine();
            Console.WriteLine("Enter the Lettuce :");
            Lettuce = Console.ReadLine();
            Console.WriteLine("Enter the Cauliflower :");
            Cauliflower = Console.ReadLine();
            Console.WriteLine("Enter the Mushroom :");
            Mushroom = Console.ReadLine();
            Console.WriteLine("Enter the Garlic :");
            Garlic = Console.ReadLine();
            Console.WriteLine("Enter the Ginger :");
            Ginger = Console.ReadLine();
            Console.WriteLine("Enter the Lemon :");
            Lemon = Console.ReadLine();

        }

        public void DisplayShoppingBillInformation()
        {
            Console.WriteLine("Customer Name : " + CustomerName);
            Console.WriteLine("Discount : " + Discount);
            Console.WriteLine("VAT : " + VAT);
            Console.WriteLine("IsMember : " + IsMember);
            Console.WriteLine("InvoiceNumber : " + InvoiceNumber);
            Console.WriteLine("Potato : " + Potato);
            Console.WriteLine("Tomato : " + Tomato);
            Console.WriteLine("Onion : " + Onion);
            Console.WriteLine("Cucumber : " + Cucumber);
            Console.WriteLine("Carrot : " + Carrot);
            Console.WriteLine("Cabbage : " + Cabbage);
            Console.WriteLine("Broccoli : " + Broccoli);
            Console.WriteLine("Spinach : " + Spinach);
            Console.WriteLine("Lettuce : " + Lettuce);
            Console.WriteLine("Cauliflower : " + Cauliflower);
            Console.WriteLine("Mushroom : " + Mushroom);
            Console.WriteLine("Garlic : " + Garlic);
            Console.WriteLine("Ginger : " + Ginger);
            Console.WriteLine("Lemon : " + Lemon);
        }

        public void CalculateTotalBill()
        {
            int potato = int.Parse(Potato);
            int tomato = int.Parse(Tomato);
            int onion = int.Parse(Onion);
            int cucumber = int.Parse(Cucumber);
            int carrot = int.Parse(Carrot);
            int cabbage = int.Parse(Cabbage);
            int broccoli = int.Parse(Broccoli);
            int spinach = int.Parse(Spinach);
            int lettuce = int.Parse(Lettuce);
            int cauliflower = int.Parse(Cauliflower);
            int mushroom = int.Parse(Mushroom);
            int garlic = int.Parse(Garlic);
            int ginger = int.Parse(Ginger);
            int lemon = int.Parse(Lemon);
            double discount = double.Parse(Discount) / 100;
            double vat = double.Parse(VAT) / 100;
            double totalBill = potato + tomato + onion + cucumber + carrot + cabbage + broccoli + spinach + lettuce + cauliflower + mushroom + garlic + ginger + lemon;
            double discountedBill = totalBill - (totalBill * discount);
            double finalBill = discountedBill + (discountedBill * vat);
            Console.WriteLine("Total Bill: " + totalBill);
            Console.WriteLine("Discounted Bill: " + discountedBill);
            Console.WriteLine("Final Bill (with VAT): " + finalBill);
        }

    }
}
