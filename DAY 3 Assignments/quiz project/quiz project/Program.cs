using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0, ans;
            string name;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("**************************************************");
            Console.WriteLine("Hi{0},Welcome to quiz by JEEVITHA", name);
            Console.WriteLine("**************************************************");

            Console.WriteLine("Q1.What is the fullform of NB:");
            Console.WriteLine("1.Nation Benefits  2.National Benefits  3.National Bureau  4.Nation Branch");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 1)
                score += 20;

            Console.WriteLine("Q2.Which year NB was founded......:");
            Console.WriteLine("1.1999   2.1996  3.2000   4.2015");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 4)
                score += 20;


            Console.WriteLine("Q3.Who is the founder of NB:");
            Console.WriteLine("1.Glenn Parker  2.Michel Parker 5  3.Glenn M Parker  4.Glenn M");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 3)
                score += 20;

            Console.WriteLine("Q4.What is the fullform of OTC:");
            Console.WriteLine("1.On The Company  2.Over The Counter  3.Over The Company  4.On The Count");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 2)
                score += 20;


            Console.WriteLine("Q5.Where is the headquarters of NB");
            Console.WriteLine("1.Florida  2.France  3.America  4.India");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 1)
                score += 20;
            Console.WriteLine("**************************************************");
            if (score >= 60)
                Console.WriteLine("Congratulations {0}, You got {1}% in this quiz", name, score);
            else
                Console.WriteLine("Sorry {0}, you got only {1}%. Try again", name, score);
            Console.WriteLine("**************************************************");

            Console.ReadLine();



        }
    }
}
