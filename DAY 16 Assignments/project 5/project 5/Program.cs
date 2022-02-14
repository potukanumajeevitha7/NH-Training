using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JEEVILibrary;
//**************************************************************
  //  Author: JEEVITHA
    //Purpose: Console Application 
//**************************************************************
namespace project_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            m.ReadData();
            Console.WriteLine(m.GetFactorial());
            Console.WriteLine("**********************************************");  
            Chemistry c = new Chemistry();
            Console.WriteLine(c.GetMethane());
            Console.WriteLine("**********************************************");
            int u = 10;
            int a = 5;
            int t = 4;
            var p = new Physics();
            var v = p.FinalVelocity(u, a, t);
            Console.WriteLine(v);
            Console.ReadLine();

        }

    }
}
