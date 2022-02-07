using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math_class
{
    class Mathematics
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }
        public static int Mul(int a, int b)
        {
            return (a * b);
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Mathematics.Add(8, 7));
            Console.WriteLine(Mathematics.Sub(30, 14));
            Console.WriteLine(Mathematics.Mul(14, 7));

            Console.ReadLine();
        }
    }
}
