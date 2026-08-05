using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Problem_Solving.Variable
{
    public class MobileRechargeSystem
    {
        public void AcceptMobileRechargeInformations()
        {


            string CustormerName = "Rashed Ahmed";
            int phoneNumber = 01407707709;
            int rechargeAmmount = 500;
            int Bounus = 50;
            string Vat = "7";
            bool IsPrepaid = true;

            long phone = phoneNumber;
            decimal recharge = rechargeAmmount;
            float vat = float.Parse(Vat);
            double bonus = Bounus;
            IsPrepaid = false;

            Console.WriteLine("Customer Name : " + CustormerName);
            Console.WriteLine("Phone Number : " + phone);
            Console.WriteLine("Recharge Amount : " + recharge);
            Console.WriteLine("Bonus : " + bonus);
            Console.WriteLine("VAT : " + vat);
            Console.WriteLine("Is Prepaid : " + IsPrepaid);

        }
    }
}
