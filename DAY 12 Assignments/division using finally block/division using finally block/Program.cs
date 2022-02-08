using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace division_using_finally_block
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, c;
                Console.WriteLine("Enter first number:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("answer = {0}", c);
                Console.ReadLine();
            }
            catch (OverflowException Ex)
            {
                Console.WriteLine("only numbers between 0 and 100000 are allowed");
                
            }
            catch (DivideByZeroException Ex)
            {
                Console.WriteLine("cannot divide with zero");
                
            }
            finally
            {
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n Designed by Jeevitha");
                Console.ReadLine();
            }

        }
    }
}
