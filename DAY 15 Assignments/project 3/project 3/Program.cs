using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader str = new StreamReader("E:\\NBHTraining\\C# Training\\DAY 15 Assignments\\Server");
            string data = str.ReadLine();
            while (data != null)
            {
                Console.WriteLine(data);
                data = str.ReadLine();
            }
            Console.WriteLine(" \n \n file reading done");
            Console.ReadLine();

        }
    }
}
