using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1.Problem_Solving.Operator
{
    public class OperatorMobileRechargeSystem
    {
        string CustomerName;
        int MobileNumber, CurrentBalance, RechargeAmount;
        public void MobileReachargeSytemInfo()
        {
            Console.WriteLine("Enter the Customer Name : ");
            CustomerName = Console.ReadLine();
            Console.WriteLine("Enter the MobileNumber : ");
            MobileNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the CurrentBalance : ");
            CurrentBalance = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the RechargeAmount : ");
            RechargeAmount = Convert.ToInt32(Console.ReadLine());


        }
        public void DisplayMobileReachargeSystem()
        {
            Console.WriteLine("CustomerName : " + CustomerName);
            Console.WriteLine("MobileNumber : " + MobileNumber);
            Console.WriteLine("CurrentBalance : " + CurrentBalance);
            Console.WriteLine("RechargeAmount : " + RechargeAmount);
        }


        public void CalculateMobileReacharge()
        {
            int Bonus = RechargeAmount > 100 ? RechargeAmount + 10 : 0;
            Console.WriteLine(Bonus);
            int vat = 10;
            int totalReachargeAmmount = RechargeAmount + (RechargeAmount * vat / 100);
            Console.WriteLine("total Reacharge Ammount : " + totalReachargeAmmount);

            int finalBalance = CurrentBalance + totalReachargeAmmount;
            Console.WriteLine("final balance is : " + finalBalance);

            string offerAndNet = RechargeAmount > 100 ? "you get offer and internet to use " : "you got nothing ";
            Console.WriteLine("offer And Net : " + offerAndNet);

            int TransactionId = 1123;
            TransactionId++;
            Console.WriteLine("Transaction Id is : " + TransactionId);
        }


    }
}
