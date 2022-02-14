using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//**********************************************************
  //  Author: JEEVITHA
    //Purpose; To create a johney library
//**********************************************************
namespace JohneyLibrary
{
    public static class Mathematics
    {
        public static int Factorial(int n)
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
