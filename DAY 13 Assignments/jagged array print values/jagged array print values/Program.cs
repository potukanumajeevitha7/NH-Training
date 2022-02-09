using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged_array_print_values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] values = new int[3][];
            values[0] = new int[] { 7, 8, 6 };
            values[1] = new int[] { 10, 12, 14, 11, 23 };
            values[2] = new int[] { 14, 11, 30, 3, 7, 8, 78 };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < values [i].Length; j++)
                {
                    Console.Write (values [i][j]+" ");
                }
                Console.Write("\n");
                
            }
            Console.ReadLine();
        }
    }
}
