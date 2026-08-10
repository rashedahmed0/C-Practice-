using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1.Problem_Solving.Operator
{
    public class OperatorElectricityBillCalculator
    {
        string CustomerName;
        int MeterNumber, PreviousReading, CurrentReading, UnitPrice;

        public void ElectricityBillCalculator()
        {
            Console.WriteLine("Enter the Customer Name :");
            CustomerName = Console.ReadLine();
            Console.WriteLine("Enter the MeterNumber :");
            MeterNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the PreviousReading :");
            PreviousReading = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the CurrentReading :");
            CurrentReading = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the UnitPrice :");
            UnitPrice = Convert.ToInt32(Console.ReadLine());


        }

        public void DisplayElectricityBill()
        {
            Console.WriteLine("CustomerName : " + CustomerName);
            Console.WriteLine("MeterNumber : " + MeterNumber);
            Console.WriteLine("PreviousReading : " + PreviousReading);
            Console.WriteLine("CurrentReading : " + CurrentReading);
            Console.WriteLine("UnitPrice : " + UnitPrice);

        }

        public void CalculateElectricityBill()
        {
            int usedUnit = CurrentReading - PreviousReading;
            Console.WriteLine("use Unit " + usedUnit);

            int EnergyBill = usedUnit * UnitPrice;
            Console.WriteLine(EnergyBill);

            int vat = (EnergyBill * 10 / 100);

            int totalBill  = EnergyBill + vat;
            Console.WriteLine("total Bill" + totalBill);

        }


    }
}
