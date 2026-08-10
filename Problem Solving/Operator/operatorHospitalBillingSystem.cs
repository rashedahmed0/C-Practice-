using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1.Problem_Solving.Operator
{
    public class OperatorHospitalBillingSystem
    {
        string PatientName;
        bool isVip;
        int Age, DoctorFee, MedicineCost, CabinCost, TestCost , Discount;
        public void HospitalBillingSytemInfo()
        {
            Console.WriteLine("Enter PaientName : ");
            PatientName  = Console.ReadLine();
            Console.WriteLine("Enter the Age : ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Doctor Fee :");
            DoctorFee = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Enter the MedicineCost : ");
            MedicineCost = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the CabinCost : ");
            CabinCost = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the TestCost : ");
            TestCost = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Discount : ");
            Discount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the isVip : ");
            isVip = bool.Parse(Console.ReadLine());

        }
        public void DisplayHospitalBillingSystem()
        {
            Console.WriteLine("PatientName" + PatientName);
            Console.WriteLine("Age" + Age);
            Console.WriteLine("DoctorFee" + DoctorFee);
            Console.WriteLine("MedicineCost" + MedicineCost);
            Console.WriteLine("CabinCost" + CabinCost);
            Console.WriteLine("TestCost" + TestCost);
            Console.WriteLine("Discount" + Discount);
            Console.WriteLine("isVip" + isVip);
        }

        public void CalculateHospitalBilling()
        {
            int totalCost = DoctorFee + MedicineCost + CabinCost + TestCost;
            Console.WriteLine("total cost is : " + totalCost);

            int billAfterVat = totalCost + (totalCost * 10 / 100);
            Console.WriteLine("bill after vat : " + billAfterVat);

            int totalAfterDiscount = billAfterVat * Discount / 100;
            Console.WriteLine("After discount total bill is : " + totalAfterDiscount);

            bool isAdoult = Age >  18 ? true : false;
            Console.WriteLine("Your Adulity is :" + isAdoult);

            string  VipDicsount  = isVip == true ? " your vip discount is active " : "your vip discount is not active ";
            Console.WriteLine(isVip);




        }


    }
}
