using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//*********************************************************************
  //  Author: JEEVITHA
    //Purpose: factorial of a number using windows application
//**********************************************************************

namespace jeevitha7library
{
    public static partial class Mathematics1
    {
        public static  int Factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)

                fact = fact * i;
            return fact;

        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int mul(int a, int b)
        {
            return (a * b);
        }


    }
}
