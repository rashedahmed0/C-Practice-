using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1.Problem_Solving.Operator
{
    public class OperatorShoppingBillSystem
    {
        string CustomerName, Quantity, Price, Discount, VAT;
        int  Potato , Onion , Chillis , Rice , Oil;

        public void AcceptShoppingBillInfo()
        {
            Console.WriteLine("Enter the Coustomer Name ; ");
            CustomerName = Console.ReadLine();
            Console.WriteLine("Enter the Quantity ");
            Quantity = Console.ReadLine();
            Console.WriteLine("Enter the Discount : ");
            Discount = Console.ReadLine();
            Console.WriteLine("Enter the vat : ");
            VAT = Console.ReadLine();
            Console.WriteLine("Enter the Potato : ");
            Potato = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Onion : ");
            Onion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Chillis : ");
            Chillis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Rice : ");
            Rice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Oil : ");
            Oil = Convert.ToInt32(Console.ReadLine());

        }

        public void DisplayShoppingBillInfo()
        {
            Console.WriteLine("CustomerName :" + CustomerName);
            Console.WriteLine("Quantity :" + Quantity);
            Console.WriteLine("Discount :" + Discount);
            Console.WriteLine("VAT :" + VAT);
            Console.WriteLine("Potato :" + Potato);
            Console.WriteLine("Onion :" + Onion);
            Console.WriteLine("Chillis :" + Chillis);
            Console.WriteLine("Oil :" + Oil);
        }

        public void CalculationBillInfo()
        {
            int Subtotal = Potato + Onion + Chillis + Oil + Rice;
            Console.WriteLine("Subtotal :" + Subtotal);

            int total = Subtotal + Convert.ToInt32(VAT);
            Console.WriteLine("total :" + total);

            int DiscountAmount = total * 10 / 100;
            Console.WriteLine("DiscountAmount :" + DiscountAmount);

            int totalPriceAfterDiscount = total - DiscountAmount;
            Console.WriteLine(totalPriceAfterDiscount);

            bool EligibleForFreeDelivery  = total > 500 ? true : false;
            Console.WriteLine("your free delivery Eligiblity : " + true);

        }
    }
}
