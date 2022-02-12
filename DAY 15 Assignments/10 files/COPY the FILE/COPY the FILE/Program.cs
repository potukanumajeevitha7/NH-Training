using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;5
using System.Threading.Tasks;

namespace COPY_the_FILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.Copy("E:\\NBHTraining\\C# Training\\DAY 15 Assignments\\10 files\\Hello.text", "E:\\NBHTraining\\C# Training\\DAY 15 Assignments\\Server\\Hello.text");
            Console.WriteLine("file copy done");
            Console.ReadLine();
        }
    }
}