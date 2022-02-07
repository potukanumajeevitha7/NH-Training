using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_emp_with_only_properties
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public int Salary { get; set; }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Id = 123;
            Console.WriteLine($"id = {emp.Id}");
            emp.Name = "JOHN";
            Console.WriteLine($"name = {emp.Name}");
            emp.Designation = "developer";
            Console.WriteLine($"designation = {emp.Designation}");
            emp.Salary = 50000;
            Console.WriteLine(emp.Salary);
            Console.ReadLine();

        }
    }
}
