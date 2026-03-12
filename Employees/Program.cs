using System;
using System.Collections.Generic;
using System.Text;

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
                 int choice = int.Parse(Console.ReadLine());

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
                }

                static void addEmploye()
                {
                    Employee s = new Employee();


                    Console.WriteLine("Enter Employee Id");
                    s.emp_id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Employee First Name");
                    s.Name = Console.ReadLine();
                    Console.WriteLine("Enter Employee Last Name");
                    s.LastName = Console.ReadLine();
                    Console.WriteLine("Enter Employee Salary");
                    s.salary = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Employee ");
                    s.Department = Console.ReadLine();

                    Console.WriteLine("Enter Employee layer L");

                    s.Layer =Console.ReadLine() ;

                    employees.Add(s);



                }
                static  void showemploye()
                {
                    foreach(var item in employees)
                    {
                        Console.WriteLine($"{item.emp_id} {item.Name} {item.LastName} {item.Department} {item.salary} {item.Layer}");
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
                       int id = int.Parse(Console.ReadLine());
                    var employeeg = employees.Where(x=>x.emp_id == id);
                    var deleteid = employees.FirstOrDefault(s => s.emp_id == id);
                    if(employeeg == null || deleteid == null)
                    {
                        Console.WriteLine("Nopt Found Employee");
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
