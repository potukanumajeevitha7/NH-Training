﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//***********************************************************************
// Author: JEEVITHA
// Purpose: find the first num after 1000 which is divisible by 97.
//          [ using for loop and break ]
//***********************************************************************

namespace Project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i=1000; i<1097; i++)
            {
                if (i%97 == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
                
            }
            Console.ReadLine();
        }
    }
}
