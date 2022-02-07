using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces_scalene_triangle
{
    interface IShape
    {
        int CalculatePerimeter();
        int CalculateArea();
    }
    class Scalene : IShape
    {
        private int side1;
        private int side2;
        private int side3;
        public void ReadSide()

        {
            Console.WriteLine("enter side1:");
            side1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("enter side2:");
            side2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter side3:");
            side3 = Convert.ToInt32(Console.ReadLine());
        }



        public int CalculateArea()
        {
            int s = (side1 + side2 + side3) / 2;
            int area = (int)Math.Sqrt((s * (s - side1) + (s - side2) + (s - side3)));
            return area;
        }

        public int CalculatePerimeter()
        {
           return side1+side2 + side3;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Scalene s= new Scalene();
            s.ReadSide();
            
            Console.WriteLine(s.CalculatePerimeter());
            Console.WriteLine(s.CalculateArea());
            Console.ReadLine();
        }
    }
}
