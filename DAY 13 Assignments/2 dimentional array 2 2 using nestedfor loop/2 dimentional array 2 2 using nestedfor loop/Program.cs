using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_dimentional_array_2_2_using_nestedfor_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[2, 2];
            data[0, 0] = 7;
            data[0, 1] = 14;
            data[1, 0] = 8;
            data[1, 1] = 30;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)

                {
                    Console.Write(data [i, j] + " ");
                }
                Console.Write(" \n ");
                Console.ReadLine();
            }
        }
    }
}