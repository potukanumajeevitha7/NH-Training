using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//***********************************************************************
  //  Author: JEEVITHA
    //Purpose: to print multiplication of a table
//***********************************************************************

namespace Project_6
{
    class Mathematics
    {
        int n;
        public void ReadData()
        {
            Console.WriteLine("enter n number");
            n = Convert.ToInt32(Console.ReadLine());
        }
        public void GetMultiplication()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n + "x" + i + "=" + n * i);
            }
        } 
        
 }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            m.ReadData();
            m.GetMultiplication();
            Console.ReadLine();
        }
    }
}
