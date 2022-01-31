using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_int_and_values_and_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>();
            int sum = 0;
            data.Add(7);
            data.Add(8);
            data.Add(30);
            data.Add(14);
            data.Add(11);
            foreach (var d in data)
            {
                sum = sum + d;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
