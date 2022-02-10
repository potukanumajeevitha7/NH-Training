using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//***************************************************
// Author: JEEVITHA
// Purpose: illustrate auto implemented properties
//***************************************************

namespace Project_5
{
    internal class Program
    {
        class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Designation { get; set; }
            public int Salary { get; set; }
        }
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Id = 78;
            Console.WriteLine($"id = {emp.Id}");
            emp.Name = "JEEVITHA";
            Console.WriteLine($"name = {emp.Name}");
            emp.Designation = "developer";
            Console.WriteLine($"designation = {emp.Designation}");
            emp.Salary = 50000;
            Console.WriteLine(emp.Salary);
            Console.ReadLine();
        }
    }
}
