using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("E:\\NBHTraining\\C# Training\\DAY 15 Assignments\\10 files\\Hello.text", "jeevitha");
            Console.WriteLine("file done");
            Console.ReadLine();

        }
    }
}
