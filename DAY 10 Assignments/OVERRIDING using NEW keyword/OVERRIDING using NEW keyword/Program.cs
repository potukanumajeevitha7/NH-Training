using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OVERRIDING_using_NEW_keyword
{
    class EnglishMessage
    {
        public void PrintHi()
        {
            Console.WriteLine("Hi");
        }
        public void PrintHello()
        {
            Console.WriteLine("Hello");
        }
        public void PrintGM()
        {
            Console.WriteLine("Good Morning");
        }
    }
    class TeluguMessage : EnglishMessage
    {
        public new void PrintGM()
        {
            Console.WriteLine("Subhodayam");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TeluguMessage teluguMessage = new TeluguMessage();  
            teluguMessage.PrintHi();
            teluguMessage.PrintHello();
            teluguMessage.PrintGM();
            Console.ReadLine();
        }
    }
}
