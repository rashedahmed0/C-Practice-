using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1.Problem_Solving.Variable
{
    public  class LibraryManagementSystem
    {

        public void AcceptLibraryInformatnio()
        {
            //Student Name Book Name Book ID Number of Books Fine Library Card Number Is Returned
            string StudentName = "Rashed Ahemd";
            string BookNmae = "C# Programming ";
            int bookId = 1234;
            int nubmer = 01407707709;
            int numberOfBooks = 5;
            int fine = 500;
            int libraryCardNumber = 33443;
            bool IsRetrend = false ;

            float bookIdFloat = bookId;
            double fineDouble = fine;
            decimal numberDecimal = nubmer; 
            byte numberOfBookByte = (byte)numberOfBooks;

            IsRetrend = true; 
            Console.WriteLine("Student Name : " + StudentName);
            Console.WriteLine("Book Name : " + BookNmae);
            Console.WriteLine("Book ID : " + bookIdFloat);
            Console.WriteLine("Number : " + numberDecimal);
            Console.WriteLine("Number of Books : " + numberOfBookByte);
            Console.WriteLine("Fine : " + fineDouble);
            Console.WriteLine("Library Card Number : " + libraryCardNumber);
            Console.WriteLine("Is Returned : " + IsRetrend);



        }
    }
}
