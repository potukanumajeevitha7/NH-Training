using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//*********************************************************
  //  Author: JEEVITHA
  //  Purpose: To print hello world [Think object oriented]
//**********************************************************
namespace Project_1
{
    class Message
    {
        public static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Message.PrintHelloWorld();
            Console.ReadLine();

        }
    }
}
