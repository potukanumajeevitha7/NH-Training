using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLibrary;
//***********************************************************************
//Author: JEEVITHA
//Purpose: To create Employee Management Application by using ClientApp
//***********************************************************************

namespace JeevithaClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch;
            string choice;
            do
            {
                Console.WriteLine("**********************************************");
                Console.WriteLine("Employee Management Application");
                Console.WriteLine("**********************************************");
                Console.WriteLine("1. Add Employee:");
                Console.WriteLine("2. Search Employee by Id:");
                Console.WriteLine("3. Search Employee by Name:");
                Console.WriteLine("4. Display All Employees:");
                Console.WriteLine(" Enter Your Choice:");
                ch =Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        SearchEmployeeById();
                        break;
                    case 3:
                        SearchEmployeeByName();
                        break;
                    case 4:
                        DisplayAllEmployees();
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                Console.WriteLine("Do You want to Continue (y/n):");
                choice = Console.ReadLine();
            } while (choice.Equals("y"));
        }
        // Add employees details
        public static void AddEmployee()
        {
            int id, salary, age;
            string name;
            Console.WriteLine("Enter id:");
            id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter salary:");
            salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter age:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();

            // call BLL Method
            var result = EmployeeBLL.AddEmployee(id, name, salary, age);
            if (result)
                Console.WriteLine("Employee Details Saved Successfully");
            else
                Console.WriteLine("some error occured");
        }
        // search employees by using ID
        public static void SearchEmployeeById()
        {
            int id;
            Console.WriteLine("Enter id:");
            id = Convert.ToInt32(Console.ReadLine());
            var result = EmployeeBLL.GetEmployeeById(id);
            if (result.Count == 0)
                Console.WriteLine("No records exists with this id");
            else
            {
                result.ForEach(p => Console.WriteLine(p));
            }
        }
        // search employee details by using name
        public static void SearchEmployeeByName()
        {
            string name;
            Console.WriteLine("Enter name:");
            name=Console.ReadLine();
            var result=EmployeeBLL.GetEmployeeByName(name);
            if (result.Count == 0)
                Console.WriteLine("No records exists with this name");
            else
            {
                result.ForEach(p => Console.WriteLine(p));
            }
        }
        // display all employees details
        public static void DisplayAllEmployees()
        {
          var result = EmployeeBLL.GetAllEmployees();
            result.ToList().ForEach(p => Console.WriteLine(p));
        }
    }
}
