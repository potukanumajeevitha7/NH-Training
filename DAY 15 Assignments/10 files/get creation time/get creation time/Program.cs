using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace get_creation_time
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine( File.GetCreationTime("E:\\NBHTraining\\C# Training\\DAY 15 Assignments\\10 files\\add data"));
            Console.ReadLine();
        }
    }
}
