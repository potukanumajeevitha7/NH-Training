using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraytypemismatch_exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = { "rose", "lotus", "apple" };
            object[] array2 = array1;
            array2[0] = 5;
            Console.ReadLine();
        }
    }
}
