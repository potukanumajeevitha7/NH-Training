using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set_get_id_name_designation_salary
{
    class Employee
    {
        private int id;
        private string name;
        private string designation;
        private int salary;

        public int Id
        {
            get { return id; }
            set { id = 123; }
        }
        public string Name
        {
            get { return name; }
            set { name = "JOHN"; }
        }
        public string Designation
        {
            
            set { designation = value; }
        }
        public int Salary
        {
            get
            {
                salary = (designation == "S") ? 25000 : 50000;
                return salary;
            }
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Id = 123;
            Console.WriteLine(emp.Id);
            emp.Name = "JOHN";
                Console.WriteLine(emp.Name);
            emp.Designation = "M";
            Console.WriteLine(emp.Salary);
            Console.ReadLine();
        }
    }
}
