using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackoverflow_exception
{
    internal class Program
    {
        static void Recurse (int val)
        {
            Console.WriteLine (val);
            Recurse(++val);
        }
        static void Main(string[] args)
        {
            Recurse(1);
            Console.ReadLine();
        }
    }
}
