using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUEUE_USING_PEEK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> data = new Queue<int>();
            data.Enqueue(17);
            data.Enqueue(28);
            data.Enqueue(39);
            Console.WriteLine(data.Count);
            Console.WriteLine(data.Peek());
            Console.WriteLine(data.Count);

            Console.ReadLine();


        }
    }
}
