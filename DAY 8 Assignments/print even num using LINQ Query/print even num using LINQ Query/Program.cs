using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_even_num_using_LINQ_Query
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>() { 7, 8, 21, 30, 24, 18, 27, 22 };
            // even nums using LINQ query
            var result = from d in data
                         where d%2==0
                         select d;
            result.ToList().ForEach(d => Console.WriteLine(d));
            Console.ReadLine();
        }
    }
}
