using ConsoleApp1.BigProject.BankManagementSystem;
using ConsoleApp1.BigProject.StudentManagementSystem;
using ConsoleApp1.Example;
using ConsoleApp1.OOP.Abstract;

//using ConsoleApp1.OOP.Basic;
using ConsoleApp1.OOP.Basic.Abstruction;
using ConsoleApp1.OOP.Basic.Constractor;
using ConsoleApp1.OOP.Basic.Inheritance;
using ConsoleApp1.OOP.Basic.Inheritance.Area;
using ConsoleApp1.OOP.Basic.Instance_And_Static_Practice;
//using ConsoleApp1.OOP.Encapsulation;
using ConsoleApp1.OOP.Inheritance;
using ConsoleApp1.OOP.Polymorphism;
using ConsoleApp1.Problem_Solving.Array;
using ConsoleApp1.Problem_Solving.Condition.BasicProblem;
using ConsoleApp1.Problem_Solving.Dictionary;
using ConsoleApp1.Problem_Solving.Enum;
using ConsoleApp1.Problem_Solving.List;
using ConsoleApp1.Problem_Solving.Loop;
using ConsoleApp1.Problem_Solving.Operator;
using ConsoleApp1.Problem_Solving.Queue;
using ConsoleApp1.Problem_Solving.TryCatchThrow;
using ConsoleApp1.Problem_Solving.Variable;
using ConsoleApp1.RECAP1.Variables___Data_Types;
using ConsoleApp1.Syntax.Variable_Syntax;
using System.Net.Http.Headers;

namespace ConsoleApp1
{
    public class Program
    {

        static void ProgamEx()
        {
            Console.WriteLine("static program ");
        }
        static void Main(string[] args)
        {
            VariablesDataTypes obj = new VariablesDataTypes();
            //obj.StudentInformation();
            //obj.ProductPrice();
            obj.typeConversion();
            //obj.tepmeratureConversion();


            //Sum obj = new Sum();
            //obj.AcceptCalcution(5, 2);
            //obj.Minuss();
            //obj.Sums();
            //obj.Multi(); 



            //Cat obj = new Cat();
            //obj.AcceptAnamal("harry");
            //obj.DisplayAnimal();
            //obj.Sound();


            //Dog obj1 = new Dog();
            //obj1.AcceptAnamal("tomy");
            //obj1.DisplayAnimal();
            //obj1.Sound(); 





            //Developer dev1 = new Developer();




            //Employees Emp1 = new Employees();
            //Emp1.AcceptPerson("Rased" , 25);
            //Emp1.AcceptEmployee(10000);
            //Emp1.DisplayEmployee(); 


            //Students obj = new Students();
            //obj.AcceptPerson("Rial" , 25);
            //obj.AcceptStudent(101);
            //obj.DisplayStudents();


            //Person preson = new Person();
            //preson.AcceptPerson("rial" ,22);
            //preson.DisplayPerson();

            //Person preson1 = new Person();
            //preson1.AcceptPerson("Rashed" ,22);
            //preson1.DisplayPerson();


            //Products obj = new Products();
            //obj.ProductId = 101;
            //obj.ProductPrice = 350;
            //obj.ProductQuantity = 3;
            //obj.Calculation();
            //obj.Display();


            //Banks obj = new Banks();
            //obj.AcceptBank("rial" , 011 , 10000);
            //obj.Deposit(5000);
            //obj.Withdraw(2000);
            //obj.Display();

            //Students obj = new Students();
            //obj.AcceptStudent("rial" , 01 , 25);
            //obj.DisplayStudent();
            //Students obj1 = new Students();
            //obj1.AcceptStudent("rashed" , 02 , 26);
            //obj1.DisplayStudent();



            //AbstructionBasicExample obj = new AbstractBasixExamleChild();
            //obj.AcceptAB(5,2);
            //obj.Triangle();
            //obj.DisplayArea();


            //AbstructionBasicExample obj1 = new AbstractBasixExamleChild();
            //obj1.AcceptAB(5,10);
            //obj1.Ractangle();
            //obj1.DisplayArea();



            //CAreacs obj = new CAreacs();
            //obj.AccecptCircle(10);
            //obj.AreaCircle();
            //obj.DisplaryCircle();


            //TArea obj1 = new TArea();
            //obj1.TriangleAccept(5);
            //obj1.TriangleArea();
            //obj1.DisplayAreat();


            //RactangleArea obj2 = new RactangleArea();
            //obj2.AcceptRactange(5);
            //obj2.AccecptCircle(10);
            //obj2.RactangeArea();
            //obj2.DisplayRactange();





            //Employee obj = new Employee();
            //obj.BossContainer();
            //obj.ManagerContainer();
            //obj.EmployeeContainer();


            //C obj = new C();
            //obj.Fun1();
            //obj.Fun2();
            //obj.Fun3();


            //A obj = new A(); 
            //A obj1 = new B();
            //B obj2 = new B(); 
            ////B obj3 = new A(); // not possible 
            //obj.Fun();
            //obj1.Fun();
            //obj2.Fun();
            //obj.Fun1();
            //obj1.Fun1();
            //obj2.Fun1();



            //OverridingC obj = new OverridingC();
            //obj.func();

            //OverloadingExmple obj = new OverloadingExmple();
            //obj.add(5,7);
            //obj.add(5,7,9);
            //obj.add(5,7,9,2);


            //PropertyExamples obj = new PropertyExamples();
            //obj._Width = 200;
            //Console.WriteLine(obj._Width);

            //obj._Height = 500;
            //Console.WriteLine(obj._Height);

            //CopyConstructor obj = new CopyConstructor(); 
            //CopyConstructor obj1 = new CopyConstructor(obj);
            //CopyConstructor obj2 = new CopyConstructor(5, 10);


            //Constructor1 obj = new Constructor1();



            //ParameterANDReturnType obj = new ParameterANDReturnType();
            //obj.Square();
            //obj.Square2(2);
            //int data = obj.Square1();
            //Console.WriteLine(data);
            //int data = obj.Square3(2);
            //Console.WriteLine(data);



            //Calculator[] obj = new Calculator[3];
            //for (int i = 0; i < obj.Length; i++) {
            //    obj[i] = new Calculator();
            //    Console.WriteLine("enter first nubmer : ");
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("enter second nubmer : ");
            //    int b = Convert.ToInt32(Console.ReadLine());

            //    obj[i].Accept(a , b );
            //}
            //for(int i = 0; i < obj.Length; i++)
            //{
            //    obj[i].Add();
            //    obj[i].Div();
            //    obj[i].Minus();
            //    obj[i].Mult();
            //}


            //BankAccount[] obj = new BankAccount[3];
            //for(int i = 0; i < obj.Length; i++)
            //{
            //    obj[i] = new BankAccount();

            //    Console.WriteLine("enter AccountNumber");
            //    int AccountNumber = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("enter AccountHolder");
            //    string AccountHolder = Console.ReadLine();
            //    Console.WriteLine("enter Balance");
            //    int Balance = Convert.ToInt32(Console.ReadLine());

            //    obj[i].BankAccept(AccountNumber, AccountHolder, Balance);

            //}
            //for(int i = 0; i < obj.Length; i++)
            //{
            //    obj[i].BankDisplay();
            //}




            //StudentResult[] obj = new StudentResult[3];
            //for (int i = 0; i < obj.Length; i++)
            //{
            //    obj[i] = new StudentResult();
            //    Console.WriteLine("Enter the roll");
            //    int roll = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter the fee");
            //    int fee = Convert.ToInt32(Console.ReadLine());
            //    obj[i].AcceptFR(roll ,  fee);
            //}
            //for (int i = 0; i < obj.Length; i++)
            //{
            //    obj[i].DisplayFR();
            //} 
            //int maxFee = 0;
            //for (int i = 0; i < obj.Length; i++)
            //{
            //    if(maxFee < obj[i].Fee)
            //    {
            //        maxFee = obj[i].Fee;
            //    }
            //}

            //Console.WriteLine( "max fee is " + maxFee);


            //StudentResult stnd1 = new StudentResult();
            //stnd1.Accept("Rial" , 89 , 65, 77 );
            //stnd1.Display();

            //StudentResult stnd2 = new StudentResult();
            //stnd2.Accept("Rashed" , 34 , 55, 71 );
            //stnd2.Display();


            //Calculator num1 = new Calculator();
            //num1.Accept(5 , 10);
            //num1.Add();
            //num1.Div();
            //num1.Minus();
            //num1.Mult();


            //BankAccount bankholder1 = new BankAccount();
            //bankholder1.BankAccept(1101 ,"Rial" , 5000);
            //bankholder1.BankDisplay();

            //BankAccount bankholder2 = new BankAccount();
            //bankholder2.BankAccept(2202 ,"Rashed" , 15000);
            //bankholder2.BankDisplay();




            //InstanceAndStaticExample emp1 = new InstanceAndStaticExample();
            //emp1.EmployeeAccepct("rial" , "developer");
            //emp1.EmployeeDisplay();
            //InstanceAndStaticExample emp2 = new InstanceAndStaticExample();
            //emp2.EmployeeAccepct("dipto" , "designer");
            //emp2.EmployeeDisplay();


            //InstanceAndStaticExample stdnt1 = new InstanceAndStaticExample();
            //stdnt1.StudentAccept("rashed" , 1);
            //stdnt1.StudentDisplay();
            //InstanceAndStaticExample stdnt2 = new InstanceAndStaticExample();
            //stdnt2.StudentAccept("rial" ,     2);
            //stdnt2.StudentDisplay();


            //InstanceExample obj = new InstanceExample();
            //Console.WriteLine(obj.x);
            //obj.fun1();



            //Console.WriteLine("this is global static variable : " + StaticExamples.b);
            //StaticExamples.fun();


            //Students stdnt1 = new Students();
            //stdnt1.Accept(1, "rashed" , 23, "dhaka", "male");
            //stdnt1.Display();

            //Students stdnt2 = new Students();
            //stdnt2.Accept(2, "rial" , 26, "palash", "male");
            //stdnt2.Display();

            //Employees emp1 = new Employees();
            //emp1.Accept(1, "rashed" , 26);
            //emp1.Display();

            //Employees emp2 = new Employees();
            //emp2.Accept(2, "dipti" , 29);
            //emp2.Display();

            //Employees emp3 = new Employees();
            //emp3.Accept(3 , "dinar" ,37);
            //emp3.Display(); 

            //DictionaryExample obj = new DictionaryExample();
            //obj.DictionaryMethod();


            //EnumTP obj = new EnumTP();
            //obj.EnumTPExample();


            //EnumP obj = new EnumP();
            //obj.EnumpExmaple();


            //Enums obj = new Enums();
            //obj.EnumsExample();


            //TryCatchfinalThrow obj = new TryCatchfinalThrow();
            //obj.TryCatchExample();


            //QueueExmaple obj = new QueueExmaple();
            //obj.QueueProblem();





            //List obj = new List();
            //obj.listExample1();

            //BankManagementSystem obj = new BankManagementSystem();
            //obj.BankManagementSystemProject();


            //StudentManagementSystem obj = new StudentManagementSystem();
            //obj.StudentManagementSystemProject();


            //ArrayProblem obj = new ArrayProblem();
            //obj.StudentMarksAnalyzer();
            //obj.NumberSearchSystem();
            //obj.EvenOddAnalyzer();


            //ArrayExample obj = new ArrayExample();
            //obj.SingleArray();
            //obj.multidimensional();
            //obj.JaggedArray();




            //StringEXamples obj = new StringEXamples();
            //obj.StringExample();



            //MethodsExample obj = new MethodsExample();
            //obj.Method1();
            //obj.Parameters("Rial");
            //obj.Parameters2(5, 10);
            //int result = obj.ReturnType(5, 10);
            //Console.WriteLine(result);
            //obj.OptionalParameters("Rashed");
            //obj.OptionalParameters();
            //obj.NamedParameter(name : "rial" , age : 25);
            //obj.MethodOverloading(2,5);
            //obj.MethodOverloading(2,5,10);



            //LoopProblemSolving obj = new LoopProblemSolving();
            //obj.StudentMarksSystem();
            //obj.EvenOddAnalyzer();
            //obj.NumberGuessingGame();
            //obj.LoginSystem();
            //obj.ATMMenu();




            //LoopExmaple obj = new();
            //obj.ForExmaple();
            //obj.WhileLoopExample();
            //obj.DoWhileLoopExample();
            //obj.ForEachLoopExample();
            //obj.NestedLoopExample();
            //obj.ContinueLoopExample();
            //obj.BreakLoopExample();




            //SwitchProblem obj = new SwitchProblem();
            //obj.FoodOrderingSystem();
            ////obj.MenuDrivenProgram();
            ////obj.TrafficSignal();




            //IfElseProblem obj = new IfElseProblem();
            //obj.IfElseProblemPractice();



            //IfExample obj = new IfExample();
            //obj.IfProblemFirst();



            //Condition obj = new Condition();
            //obj.IfExample();
            //obj.IfElseExample();
            //obj.Nestedif();
            //obj.ElseIfExample();
            //obj.switchExample();
            //obj.SwitchExpression();

            //InputOutputExample obj = new InputOutputExample();
            //obj.OutputExample();


            //OnlineCourseManagement obj = new OnlineCourseManagement();
            //obj.AcceptOnlineCourse();
            //obj.DisplayOnlineClass();


            //OperatorElectricityBillCalculator obj = new OperatorElectricityBillCalculator();
            //obj.ElectricityBillCalculator();
            //obj.DisplayElectricityBill();
            //obj.CalculateElectricityBill();



            //OperatorMobileRechargeSystem obj = new OperatorMobileRechargeSystem();
            //obj.MobileReachargeSytemInfo();
            //obj.DisplayMobileReachargeSystem();
            //obj.CalculateMobileReacharge();

            //OperatorHospitalBillingSystem obj = new OperatorHospitalBillingSystem();
            //obj.HospitalBillingSytemInfo();
            //obj.DisplayHospitalBillingSystem();
            //obj.CalculateHospitalBilling();



            //OperatorShoppingBillSystem obj = new OperatorShoppingBillSystem();
            //obj.AcceptShoppingBillInfo();
            //obj.DisplayShoppingBillInfo();
            //obj.CalculationBillInfo();



            //OperatorBankAccountSystem obj = new OperatorBankAccountSystem();
            //obj.AcceptAccountInfo();
            //obj.DisplayAccountInfo();
            //obj.CalculateAccountBalance();


            //EmployeeSalaryManagement obj = new EmployeeSalaryManagement();
            //obj.AcceptEployeeInfo();
            //obj.DisplayEmployeeInfo();
            //obj.CalculateEmployeeSalary();



            //StudentResultSystem obj = new StudentResultSystem();
            //obj.AcceptStudentInfo();
            //obj.DisplayStudentInfo();
            //obj.CalculationStudentOperator();




            //OperatorProblemExample obj = new OperatorProblemExample();
            //obj.ArithmeticOperator();
            //obj.AssignmentOperator();
            //obj.ComparisonOperator();



            //ExamResultSystem obj = new ExamResultSystem();
            //obj.AcceptExamResultInformation();



            // MobileRechargeSystem obj = new MobileRechargeSystem();
            //obj.AcceptMobileRechargeInformations();


            //LibraryManagementSystem obj = new LibraryManagementSystem();
            //obj.AcceptLibraryInformatnio();


            //HospitalPatientSystem obj = new HospitalPatientSystem();
            //obj.AcceptHospitalPatientInformation();
            //obj.DisplayHospitalPatientInformation();




            //BankAccountSystem obj = new BankAccountSystem();
            //obj.AcceptBankAccountInformation();
            //obj.DisplayBankAccountInformation();
            //obj.CalculateBankAccout();



            //ShoppingBillSystem obj = new ShoppingBillSystem();
            //obj.AcceptShoppingBillInformation();
            //obj.DisplayShoppingBillInformation();
            //obj.CalculateTotalBill();




            //EmployeeInformationSystem obj = new EmployeeInformationSystem();
            //obj.AcceptEmployeeInformation();
            //obj.DisplayEmployeeInformation();
            //obj.SalaryCalculation();


            //StudentInformationSystem obj = new StudentInformationSystem();
            //obj.AcceptStudentInformation();
            //obj.DisplayStudentInformation();
            //obj.CalculateGPA();






            //VaraiblePracticeExamplecs obj = new VaraiblePracticeExamplecs();
            //obj.VariablePractice();
            //obj.TypeConvertion();
            //obj.ExplicitExample();
            //obj.ImplicitExmaple();



            //Console.WriteLine("Hello, World!");
        }


    }
}
