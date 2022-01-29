using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication_table_while_loop_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input, i;
            Console.WriteLine("Enter any number");
            input = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}x{1}={2}", input, i, input * i);

            }
            Console.ReadLine();

        }
    }
}
