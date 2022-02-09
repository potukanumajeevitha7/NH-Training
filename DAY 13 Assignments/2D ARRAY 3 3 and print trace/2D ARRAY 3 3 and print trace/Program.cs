using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_ARRAY_3_3_and_print_trace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[,] data = new int[3, 3];
            data[0, 0] = 7;
            data[0, 1] = 8;
            data[0, 2] = 3;
            data[1, 0] = 14;
            data[1, 1] = 11;
            data[1, 2] = 7;
            data[2, 0] = 11;
            data[2, 1] = 30;
            data[2, 2] = 8;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)

                {
                    if (i == j)
                        sum = sum + data[i, j];
                }
                    
               
            }
            Console.WriteLine(sum);
             Console.ReadLine();
        }
    }
}
