using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outof_memory_exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string val = new string ('r', int.MaxValue);
        }
    }
}
