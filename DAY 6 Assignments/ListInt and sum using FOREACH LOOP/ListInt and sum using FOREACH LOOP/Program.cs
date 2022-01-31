using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListInt_and_sum_using_FOREACH_LOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>();
            int temp;
            int sum2 = 0;
            //Read 5 nums from user
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Enter any value:");
                temp = Convert.ToInt32(Console.ReadLine());
                data.Add(temp);
            }
            //Find sum using FOREACH LOOP
            foreach (var d in data)
                sum2 = sum2 + d;
            Console.WriteLine(sum2);
            Console.ReadLine();
        }
    }
}
