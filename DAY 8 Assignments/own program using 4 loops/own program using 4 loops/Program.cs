using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace own_program_using_4_loops
{
    class Student
    {
        public string Name;
        public int Rollnum;
        public string Section;
        public int Marks;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> student = new List<Student>()
            {
              new Student { Name = "john",Rollnum =100, Section ="A",Marks=496},
              new Student { Name = "jeevitha",Rollnum =101, Section ="A",Marks=400},
              new Student { Name = "pavana",Rollnum =102, Section ="A",Marks=395},
              new Student { Name = "johney",Rollnum =103, Section ="A",Marks=456},
              new Student { Name = "mohith",Rollnum =104, Section ="A",Marks=302},
              new Student { Name = "mounika",Rollnum =105, Section ="A",Marks=399},
              new Student { Name = "raju",Rollnum =106, Section ="A",Marks=300},
            };
            Console.WriteLine("*********************************************************");
            //print marks >=400 using FORLOOP
            for (int i = 0; i < student.Count; i++)
            {
                if (student[i].Marks >= 400)
                    Console.WriteLine($"name={student[i].Name},rollnum={student[i].Rollnum}");
            }
            Console.WriteLine("****************************************************************");
            //print marks >=400 using FOREACH LOOP
            foreach (var e in student)
            {
                if (e.Marks >=400)
                    Console.WriteLine($"name={e.Name},rollnum={e.Rollnum}");
            }
            Console.WriteLine("****************************************************************");
            //print marks >=400 using LAMBDA EXPRESSION
            student.ToList().Where(e => e.Marks >=400).ToList().ForEach(e => Console.WriteLine($"name={e.Name},rollnum={e.Rollnum}"));
            Console.WriteLine("****************************************************************");
            //print marks >=400 using LINQ QUARY
            var result = from e in student
                         where e.Marks >=400
                         select e;
            result.ToList().ForEach(e => Console.WriteLine($"name={e.Name},rollnum={e.Rollnum}"));
             Console.ReadLine();
        }
    }
}
