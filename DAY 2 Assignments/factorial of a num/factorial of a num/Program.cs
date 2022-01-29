using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial_of_a_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input, product = 1, i;

            Console.WriteLine("Enter any number");
            input = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= input; i++)
                product = product * i;

            Console.WriteLine(product);

            Console.ReadLine();

        }
    }
}
