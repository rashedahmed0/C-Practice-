using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1.Problem_Solving.Variable
{
    public class HospitalPatientSystem
    {
        string PatientName, Age, Height, Weight, BloodGroup, Gender, IsAdmitted, CabinNumber, PatientID;

        public void AcceptHospitalPatientInformation()
        {
            Console.WriteLine("Enter the Patien Name : ");
            PatientName = Console.ReadLine();
            Console.WriteLine("Enter the Age : ");
            Age = Console.ReadLine();
            Console.WriteLine("Enter the Height : ");
            Height = Console.ReadLine();
            Console.WriteLine("Enter the Weight : ");
            Weight = Console.ReadLine();
            Console.WriteLine("Enter the BloodGroup : ");
            BloodGroup = Console.ReadLine();
            Console.WriteLine("Enter the Gender : ");
            Gender = Console.ReadLine();
            Console.WriteLine("Enter the IsAdmitted : ");
            IsAdmitted = Console.ReadLine();
            Console.WriteLine("Enter the CabinNumber : ");
            CabinNumber = Console.ReadLine();
            Console.WriteLine("Enter the PatientID : ");
            PatientID = Console.ReadLine();
        }
        public void DisplayHospitalPatientInformation()
        {
            int age = Convert.ToInt32(Age);
            double height = double.Parse(Height);
            decimal weight = decimal.Parse(Weight);
            float patientId = float.Parse(PatientID);
            Console.WriteLine("Patient Name : " + PatientName);
            Console.WriteLine("age : " + age);
            Console.WriteLine("height : " + height);
            Console.WriteLine("weight : " + weight);
            Console.WriteLine("BloodGroup : " + BloodGroup);
            Console.WriteLine("Gender : " + Gender);
            Console.WriteLine("IsAdmitted : " + IsAdmitted);
            Console.WriteLine("CabinNumber : " + CabinNumber);
            Console.WriteLine("PatientID : " + patientId);
        }
    }
}
