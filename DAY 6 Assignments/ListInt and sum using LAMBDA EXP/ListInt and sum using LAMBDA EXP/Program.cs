using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListInt_and_sum_using_LAMBDA_EXP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>();
            int temp;
            int sum3 = 0;
            //Read 5 nums from user
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Enter any value:");
                temp = Convert.ToInt32(Console.ReadLine());
                data.Add(temp);
            }
            //Find sum using Lambda Expression
            data.ForEach(d => sum3 = sum3 + d);
            Console.WriteLine(sum3);
            Console.ReadLine();
        }
    }
}
