using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace read_4_nums_print_value_FOREACH_LOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[4];


            
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine("Enter number:");
                data[i] = Convert.ToInt32(Console.ReadLine());

            }

           
            foreach (int d in data)
            {
                Console.WriteLine(d);
            }

            Console.ReadLine();
        }
    }
}
