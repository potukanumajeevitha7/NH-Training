using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace streamwritter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sr = new StreamWriter("E:\\NBHTraining\\C# Training\\DAY 15 Assignments\\10 files\\Hello.text");
            sr.WriteLine("HI");
            sr.WriteLine("HELLO");
            sr.WriteLine("GOOD MORNING");
            sr.Close();
        }
    }
}
