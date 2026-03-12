using System;
using System.Collections.Generic;
using System.Text;
//fixed  bugs
namespace Employees
{
     class Program
    {
        static  List<Employee> employees = new List<Employee>();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n 1: Add Employee");
                Console.WriteLine("\n 2: show Employees ");
                Console.WriteLine("\n 3: Search Employee");
                Console.WriteLine("\n 4: Delete Employee ");
                Console.WriteLine("\n 5: show top Employees");
                Console.WriteLine("\n 6: Exit");

                Console.WriteLine("Enter number you want choice :");

                 int choice ;
                while(!int.TryParse(Console.ReadLine(),out choice) )
                {
                    Console.WriteLine("Please Enter Only Numbers");
                }

                switch (choice)
                {
                    case 1:
                        addEmploye();
                        break;
                    case 2:
                        showemploye();
                        break;

                        case 3:
                        searchemployee();
                        break;

                        case 4:
                        deleteemploye();
                        break;

                        case 5:
                        topemployees();
                        break;
                        case 6:
                        return;
                    default:
                        Console.WriteLine("Default Number:");
                        return;
                }

                static void addEmploye()
                {
                    int empid;
                    int salarye;
                    int level; 
                    Employee s = new Employee();


                    Console.WriteLine("Enter Employee Id");
                    while(!int.TryParse(Console.ReadLine(),out empid))
                    {
                        Console.WriteLine("Please Enter Emp Id, Only number :");
                    }
                    bool exist = employees.Any(x => x.emp_id == empid);
                    if (exist)
                    {
                         Console.WriteLine("This Employee Id is already exist, Please try Again :");
                           
                    }
                    s.emp_id = empid;

                    Console.WriteLine("Enter Employee First Name:");
                    s.Name = Console.ReadLine();
                    Console.WriteLine("Enter Employee Last Name:");
                    s.LastName = Console.ReadLine();
                    Console.WriteLine("Enter Employee Salary:");
                    while (!int.TryParse(Console.ReadLine(), out salarye))
                    {
                        Console.WriteLine("Please Enter Salary , Only number: ");
                    }
                    s.salary = salarye ;

                    Console.WriteLine("Enter Employee Deparment: ");

                    s.Department = Console.ReadLine();

                    Console.WriteLine("Enter Employee layer L :");
                    while (!int.TryParse(Console.ReadLine(), out level))
                    {
                        Console.WriteLine("Please Enter Layer ,  Only number: ");
                    }
                    s.Layer =level;

                    employees.Add(s);



                }
                static  void showemploye()
                {
                    foreach(var item in employees)
                    {
                        Console.WriteLine($"{item.emp_id} {item.Name} {item.LastName} {item.Department} {item.salary} "+$"L{item.Layer}");
                    }
                }

                static void searchemployee()
                {
                    Console.Write("Enter Employee Name:");
                    string Name = Console.ReadLine();
                    
                    var employee = employees.Where(x =>x.Name.Contains(Name));
                  foreach(var item in employee)
                    {
                        Console.WriteLine($"{item.emp_id} {item.Name}  {item.LastName} {item.salary} ");
                    }


                }
                static void deleteemploye()
                {
                    Console.WriteLine("Enter Employee id :");
                       int id ;
                    while(!int.TryParse(Console.ReadLine(),out id))
                    {
                        Console.WriteLine("Please try Again : Enter EmpId , only Number:");

                    }
                    var employeeg = employees.Where(x=>x.emp_id == id);
                    var deleteid = employees.FirstOrDefault(s => s.emp_id == id);
                    if(employeeg == null || deleteid == null)
                    {
                        Console.WriteLine("Not Found Employee");
                        return;
                    }
                    foreach(var item in employeeg)
                    {
                        Console.WriteLine($"{item.emp_id} {item.Name} {item.Department}");

                    }
                    Console.WriteLine("Are your sure want deleted y/n");
                    string cond = Console.ReadLine();
                    if(cond == "n")
                    {
                        return; 
                    }

                    employees.Remove(deleteid);



                }

                static void topemployees()
                {
                    var employeestop = employees.OrderByDescending(x => x.Layer).Take(3);

                    foreach( var item in employeestop)
                    {
                        Console.WriteLine($"{item.emp_id} {item.Name} {item.LastName} {item.Department} {item.salary} {item.Layer}");

                    }

                }



            }
        }

    }
}
