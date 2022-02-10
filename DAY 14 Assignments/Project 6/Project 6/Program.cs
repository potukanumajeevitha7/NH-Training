using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//******************************************************
// Author: JEEVITHA
// Purpose: illustrate normal properties
//******************************************************

namespace Project_6
{
    class employee
    {
        private int Id;
        private string Name;
        private string Designation;
        private int Salary;
        public int id
        {
            get { return Id; }
            set { Id = 101; }
        }
        public string name
        {
            get { return Name; }
            set { Name = "JEEVITHA"; }
        }
        public string designation
        {
            get { return Designation; }
            set { Designation = "manager"; }
        }
        public int salary
        {
            get { return Salary; }
            set { Salary = 10000; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee employee = new employee();
            employee.id = 101; 
            employee.name = "JEEVITHA";
            employee.designation = "manager";
            employee.salary = 10000;
            Console.WriteLine(employee.id);
            Console.WriteLine(employee.name);
            Console.WriteLine(employee.designation);
            Console.WriteLine(employee.salary);
            Console.ReadLine();

        }
    }
}
