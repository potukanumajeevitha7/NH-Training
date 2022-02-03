using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_emp_id_name_salary_com_ass3
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;
        public string company;

        public void ReadData()
        {
            Console.WriteLine("Enter Employee ID: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary: ");
            salary = Convert.ToInt32(Console.ReadLine());

            company = "NationsBenifts";
        }

        public void PrintData()
        {
            Console.WriteLine($"Id:{id}, Name:{name}, Salary:{salary}, Company={company}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.ReadData();
            emp1.PrintData();

            Employee emp2 = new Employee();
            emp2.ReadData();
            emp2.PrintData();
            Console.ReadLine();
 
            }
    }
}
