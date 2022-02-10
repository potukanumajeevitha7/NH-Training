using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//***********************************************************
// Author: JEEVITHA
//Purpose: print nums from 1 to 30 & skip the nums divisible 
//         by 3 [ using continue; ]
//***********************************************************

namespace Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i=1; i<=30; i++)
            {
                if (i % 3 == 0)
                    continue;
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
