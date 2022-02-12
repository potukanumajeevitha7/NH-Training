using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace append
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sr = new StreamWriter("E:\\NBHTraining\\C# Training\\DAY 15 Assignments\\10 files\\Hello.text", true);
            sr.WriteLine("hi");
            sr.WriteLine("welcome to");
            sr.WriteLine("NB Healthtech");
            sr.Close();
            Console.WriteLine("file done");
            Console.ReadLine();
        }
    }
    
}
