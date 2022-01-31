using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListInt_and_sum_using_FORLOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>();
            int temp;
            int sum1 = 0;
            //Read 5 nums from user
            for(int i=1;i<=5;i++)
            {
                Console.WriteLine("Enter any value:");
                temp = Convert.ToInt32(Console.ReadLine());
                data.Add(temp);
            }
            //find sum using FORLOOP
            for (int i=0;i<data.Count;i++)
                sum1=sum1+data[i];
            Console.WriteLine(sum1);
            Console.ReadLine();
        }
    }
}
        