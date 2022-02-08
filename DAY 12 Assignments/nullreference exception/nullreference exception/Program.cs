using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nullreference_exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] values = null;
            for (int ctr =0; ctr <=9; ctr++)
                values[ctr] = ctr * 2;
            foreach (var value in values)
                Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
