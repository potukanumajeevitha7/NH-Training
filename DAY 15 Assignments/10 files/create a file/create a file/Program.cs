using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_a_file
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.Create("E:\\NBHTraining\\C# Training\\DAY 15 Assignments\\10 files\\Hello.text");
            Console.WriteLine(" Create file done");
            Console.ReadLine();
        }
    }
}
