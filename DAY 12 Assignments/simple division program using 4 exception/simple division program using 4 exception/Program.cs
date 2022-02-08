using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_division_program_using_4_exception
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
                Console.ReadLine();
            }
            catch(DivideByZeroException Ex)
            {
                Console.WriteLine("cannot divide with zero");
                Console.ReadLine();
            }
            catch(FormatException Ex)
            {
                Console.WriteLine("only numbers are allowed. please double check");
                Console.ReadLine();
            }
            catch(Exception )
            {
                Console.WriteLine("some error occured. please contact : admin@mycompany.com");
                Console.ReadLine();
            }
        }
    }
}
