using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//**************************************************
//Author: JEEVITHA
//Purpose: example C# code for MULTI-CAST DELEGATE
//***************************************************
namespace project_2
{
    public delegate void MyCaller(int a , int b);
    internal class Program
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public static void Div(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        static void Main(string[] args)
        {
            MyCaller mc = new MyCaller(Add);
            mc += Mul;
            mc += Div;
            // 10, 20
            mc(10, 20);
            Console.WriteLine("********************************************");
            //12,24
            mc(12, 24);
            Console.WriteLine("*********************************************");
            //30,14
            mc(30, 14);

            Console.ReadLine();
        }
    }
}
