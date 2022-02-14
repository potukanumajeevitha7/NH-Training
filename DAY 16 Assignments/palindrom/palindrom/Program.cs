using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    class Palindrome
    {
        int n, rev, s = 0, temp;
        public void ReadData() 
        {
            Console.WriteLine("enter the number");
            n=Convert.ToInt32(Console.ReadLine());
        }
        public void GetPalindrome()
        {
            temp = n;
            while(n>0)
            {
                rev = n % 10;
                s = (s * 10) + rev;
                n = n / 10;
            }
            if (temp == s)
                Console.WriteLine("palindrome", n);
            else
                Console.WriteLine("not palindrome",n);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Palindrome p = new Palindrome();
            p.ReadData();
            p.GetPalindrome();
            Console.ReadLine();
        }
    }
}
