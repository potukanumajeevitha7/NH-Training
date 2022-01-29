using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_N_Natural_nums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input, sum = 0, i;
            Console.WriteLine("Enter any number:");
            input = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= input; i++)
                sum = sum + i;
            Console.WriteLine(sum);
            Console.ReadLine();

        }
    }
}
