using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JohneyLibrary;
using PublicLibrary;
//**********************************************************
  //  Author: JEEVITHA
    //Purpose: to create a client app and using johneylibrary and publiclibrary
//*****************************************************************

namespace ClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Mathematics.Factorial(6));
            Console.WriteLine(Mathematics.Add(5, 6));
            Console.WriteLine(Mathematics.mul(5, 5));
            Console.WriteLine(Physics.FinalVelocity(6, 7, 8));

            Console.ReadLine(); 
        }
    }
}
