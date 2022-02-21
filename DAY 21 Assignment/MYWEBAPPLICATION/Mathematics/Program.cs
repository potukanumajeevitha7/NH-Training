using Mathematics.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//***************************************************
// Author: JEEVITHA
// Purpose: Console Application and consume Web Application
//***************************************************

namespace Mathematics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebService1SoapClient obj = new WebService1SoapClient();
            Console.WriteLine("*********** FACTORIAL OF A NUM **********");
            Console.WriteLine(obj.Factorial(7));
            Console.WriteLine("********* ADDITION ********");
            Console.WriteLine(obj.Add(2,4));
            Console.WriteLine("************ multiplication ***********");
            Console.WriteLine(obj.Mul(7,8));
            Console.WriteLine("******** DIVISION ***********");
            Console.WriteLine(obj.Div(10,2));
            Console.ReadLine();
        }
    }
}
