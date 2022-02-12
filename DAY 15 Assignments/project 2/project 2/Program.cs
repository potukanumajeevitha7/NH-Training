using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.Copy("E:\\NBHTraining\\C# Training\\DAY 15 Assignments\\10 files\\Hello.text", "E:\\NBHTraining\\C# Training\\DAY 15 Assignments\\Server\\Hello.text");
        Console.WriteLine("File Transfered");

            Console.ReadLine();
        }
    }
}
