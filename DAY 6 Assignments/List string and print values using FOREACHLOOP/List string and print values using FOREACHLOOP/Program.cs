using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_string_and_print_values_using_FOREACHLOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> data = new List<string>();
            data.Add("JEEVITHA");
            data.Add("JOHN");
            data.Add("NETHU");
            data.Add("MOUNI");
            data.Add("PAVANA");

            //Print values using foreach Loop
            foreach (var d in data)
            {
                Console.WriteLine(d);
            }
            Console.ReadLine();
        }
    }
}
