using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack__using_pop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> data = new Stack<int>();
            data.Push(7);
            data.Push(8);
            data.Push(9);
            Console.WriteLine(data.Count);
            Console.WriteLine(data.Pop());
            Console.WriteLine(data.Count);

            Console.ReadLine();
        }
    }
}
