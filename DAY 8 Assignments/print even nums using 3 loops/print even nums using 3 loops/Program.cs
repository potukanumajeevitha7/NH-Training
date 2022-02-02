using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_even_nums_using_3_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>() { 7, 8, 21, 30, 24, 18, 27, 22 };
            Console.WriteLine("***************************************************");
            //Even nums using FOR LOOP
            for (int i=0;i<data.Count;i++)
            {
                if(data[i]%2==0)
                    Console.WriteLine(data[i]);
            }
            Console.WriteLine("*****************************************************");
            // even nums using FOREACH LOOP
            foreach(var d in data)
            {
                if (d%2==0)
                    Console.WriteLine(d);
            }
            Console.WriteLine("****************************************************");   
            // even nums using LAMBDA EXPRESSION
            data.Where(d=>d%2==0).ToList().ForEach(d => Console.WriteLine(d));
            Console.ReadLine();
        }
    }
}
