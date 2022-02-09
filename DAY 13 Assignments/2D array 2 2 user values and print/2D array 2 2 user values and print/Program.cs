using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_array_2_2_user_values_and_print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[2, 2];
            //read 
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"enter any value at ({i},{j})");
                    data[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //print
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(data [i, j] + " ");
                }
                Console.WriteLine();
            }
            
            Console.ReadLine();
        }
    }
}