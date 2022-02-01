using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_array_obj_and_init_with_5_emp
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employee = new Employee[5];

            employee[0] = new Employee() { id = 101,name="Jeevitha", salary = 5000 };
            employee[1] = new Employee() { id = 102, name = "John", salary = 7000 };
            employee[2] = new Employee() { id = 103, name = "Pavana", salary = 8000 };
            employee[3] = new Employee() { id = 104, name = "Surya", salary = 1000 };
            employee[4] = new Employee() { id = 105, name = "Siddhu", salary = 2000 };

            Console.WriteLine("==========================================================================");

            //forloop
            for (int i = 0; i < employee.Length; i++)
            {
                Console.WriteLine($"id={employee[i].id},name={employee[i].name}, salary={employee[i].salary}");

            }
            Console.WriteLine("==========================================================================");
            //foreach loop
            foreach (var e in employee)
            {
                Console.WriteLine($"id ={e.id}, name={e.name}, salary={e.salary}");
            }
            Console.WriteLine("==========================================================================");
            //Lambda Expression
            employee.ToList().ForEach(e => Console.WriteLine($"id{e.id}, name={e.name}, salary={e.salary}"));



            Console.ReadLine();


        }





    }

}
        
    

