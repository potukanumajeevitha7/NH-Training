using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_hlo_5_times_while_lop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 5)
            {
                Console.Write("Hello\n");
                i++;
            }
            Console.ReadLine();

        }
    }
}
