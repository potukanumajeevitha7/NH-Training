using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexoutofrange_exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ar = { 7, 8, 14, 11, 30 };

            for (int i=0; i<=ar.Length; i++)
                Console.WriteLine(ar[i]);
        }
    }
}
