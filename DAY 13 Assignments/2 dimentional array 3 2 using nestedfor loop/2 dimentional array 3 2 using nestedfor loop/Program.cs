using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_dimentional_array_3_2_using_nestedfor_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[,] { { 7, 8 }, { 14, 11 }, { 11, 30 } };
            //data[0, 0] = 7;
            //data[0, 1] = 8;
            //data[1, 0] = 14;
            //data[1, 1] = 11;
            //data[2, 0] = 11;
            //data[2, 1] = 30;
             for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)

                {
                    Console.Write(data[i, j] + " ");
                }
                Console.Write(" \n ");
                Console.ReadLine();
            }

        }
    }
}
