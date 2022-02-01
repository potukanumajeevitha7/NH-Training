using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_dept_class
{
    internal class Dept
    {
        public int dept_id;
        public string dept_name;
        public string course_name;

        public void ReadDept()
        {
            Console.WriteLine("Enter Dept_ID: ");
            dept_id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Dept_Name: ");
            dept_name = Console.ReadLine();

            Console.WriteLine("Enter Course_Name: ");
            course_name = Console.ReadLine();

        }

        public void PrintDepartment()
        {
            Console.WriteLine($"Dept_ID= {dept_id}, Dept_Name= {dept_name}, Course_Name= {course_name}");
        }
        static void Main(string[] args)
        {
            
                Dept dept = new Dept();
                dept.ReadDept();
                dept.PrintDepartment();


                Console.ReadLine();
            }
    }
}
