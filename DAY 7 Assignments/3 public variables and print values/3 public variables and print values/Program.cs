using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_public_variables_and_print_values
{
    class Employee
    {
        public int empid;
        public string name;
        public int salary;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.empid = 1234;
            emp.name = "John";
            emp.salary = 500000;

            //{empid =1234; name =John,  salary=500000"};
            Console.WriteLine($"empid= {emp.empid}, name={emp.name}, salary={emp.salary}");
            Console.ReadLine();
        }
    }
}
