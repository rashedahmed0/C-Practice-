using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Security.Permissions;
using System.Text;

namespace ConsoleApp1.BigProject.StudentManagementSystem
{
    public class StudentManagementSystem
    {
        class Student
        {
            public int StudentId { get; set;  }
            public string Name { get; set;  }
            public int Age { get; set;  }
            public string Gender { get; set;  }
            public string Phone  { get; set;  }
            public string Email { get; set;  }
            public string Departmne { get; set;  }
            public int Semester { get; set;  }
            public double GPA { get; set;  }
            public string Address { get; set;  }
        }
        public void StudentManagementSystemProject()
        {
            Student[] students = new Student[100];
            int studentCount = 0;
            int choice ;
            do
            {
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Show All Students");
                Console.WriteLine("3. Search Student");
                Console.WriteLine("4. Update Student");
                Console.WriteLine("5. Delete Student");
                Console.WriteLine("6. Student Result");
                Console.WriteLine("7. Class Statistics");
                Console.WriteLine("8. Sort Students");
                Console.WriteLine("9. Student Report");
                Console.WriteLine("10. Exit");

              

                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("add Student");
                        Console.WriteLine("StudentId : ");
                        int studentId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Age : ");
                        int age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Phone : ");
                        string phone = Console.ReadLine();
                        Console.WriteLine("Semester : ");
                        int semester = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("GPA : ");
                        double gpa = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Name : ");
                        string name = Console.ReadLine() ; 
                        Console.WriteLine("Gender : ");
                        string gender = Console.ReadLine() ; 
                        Console.WriteLine("Email : ");
                        string email = Console.ReadLine() ; 
                        Console.WriteLine("Departmne : ");
                        string departmne = Console.ReadLine() ; 
                        Console.WriteLine("Address : ");
                        string address = Console.ReadLine() ;

                        Student obj = new Student();

                        obj.StudentId = studentId ; 
                        obj.Age = age; 
                        obj.Phone = phone; 
                        obj.Semester = semester; 
                        obj.GPA = gpa;
                        obj.Name = name;
                        obj.Gender = gender;
                        obj.Email = email;
                        obj.Departmne = departmne;
                        obj.Address = address;

                        students[studentCount] =  obj;
                        studentCount++;

                        Console.WriteLine("Student add successfully");
                       


                        break; 
                    case 2:
                        Console.WriteLine(" Show All Students".PadRight(20));
                        Console.Write("StudentId ".PadRight(20));
                        Console.Write("Name  ".PadRight(20));
                        Console.Write("Age   ".PadRight(20) );
                        Console.Write("Phone   ".PadRight(20) );
                        Console.Write("Email   ".PadRight(20));
                        Console.Write("Departmne  ".PadRight(20) );
                        Console.Write("Semester ".PadRight(20) );
                        Console.Write("GPA  ".PadRight(20) );
                        Console.Write("Address  \n".PadRight(20) );
                        for (int i = 0; i < studentCount; i++)
                        {
                            Student student = students[i];
                            Console.Write(student.StudentId.ToString().PadRight(20));
                            Console.Write(student.Name.PadRight(20));
                            Console.Write(student.Age.ToString().PadRight(20));
                            Console.Write(student.Phone.ToString().PadRight(20));
                            Console.Write(student.Email.PadRight(20));
                            Console.Write(student.Departmne.PadRight(20));
                            Console.Write(student.Semester.ToString().PadRight(20));
                            Console.Write(student.GPA.ToString().PadRight(20));
                            Console.Write(student.Address.PadRight(20));

                        }                      
                        break;
                    case 3:
                        Console.WriteLine("Search Student");
                        for (int i = 0; i < studentCount; i++)
                        {
                            Student student = students[i];
                            Console.WriteLine("enter Student roll number : ");
                            int roll = Convert.ToInt32(Console.ReadLine());
                            if (roll == student.StudentId)
                            {
                                Console.Write(student.StudentId.ToString().PadRight(20));
                                Console.Write(student.Name.PadRight(20));
                                Console.Write(student.Age.ToString().PadRight(20));
                                Console.Write(student.Phone.ToString().PadRight(20));
                                Console.Write(student.Email.PadRight(20));
                                Console.Write(student.Departmne.PadRight(20));
                                Console.Write(student.Semester.ToString().PadRight(20));
                                Console.Write(student.GPA.ToString().PadRight(20));
                                Console.Write(student.Address.PadRight(20));
                            }
                            else
                            {
                                Console.WriteLine("enter right roll number ");
                            }


                        } 
                        break;
                    case 4:
                        Console.WriteLine("Update Student");
                        break;
                    case 5:
                        Console.WriteLine("Delete Student");
                        break;
                    case 6:
                        Console.WriteLine("Student Result");
                        break;
                    case 7:
                        Console.WriteLine("Class Statistics");
                        break;
                    case 8:
                        Console.WriteLine("Sort Students");
                        break; 
                    case 9:
                        Console.WriteLine("Student Report");
                        break; 
                    case 10:
                        Console.WriteLine("Thank you");
                        break; 
                }
            }
            while (choice != 10);
        }
    }
}
