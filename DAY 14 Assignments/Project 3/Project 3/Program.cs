using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//*********************************************************************
// Author: JEEVITHA
// Purpose: to check the num is prime or not [ use break; ]
//*********************************************************************

namespace Project_3
{
    class Prime
    {
        public void Isprime()
        {
            int n=78 , i;
            for (i=2;i<n;i++)
            {
                if (n % i == 0)
                    break;
            }
            if (i == n)
                Console.WriteLine("IT IS A PRIME NUMBER");
            else
                Console.WriteLine("IT IS NOT A PRIME NUMBER");
        }
    }
        
    internal class Program
    {
        static void Main(string[] args)
        {
            Prime prime = new Prime();
            prime.Isprime();
            Console.ReadLine();
        }
    }
}
