using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//********************************************************
//Author: JEEVITHA
//Purpose: C# code using out parameter
//********************************************************

namespace project_5
{
    internal class Program
    {
        public static string GetNextNameByOut(out int id)
        {
            id = 1;
            string returnText = "Next-" + id.ToString();
            return returnText;
        }

        static void Main(string[] args)
        {
            int i =0;
            Console.WriteLine("Previous value of integer i:" + i.ToString());
            string test = GetNextNameByOut(out i);
            Console.WriteLine("Current value of intger i:" + i.ToString());
            Console.ReadLine();

        }
    }
}
