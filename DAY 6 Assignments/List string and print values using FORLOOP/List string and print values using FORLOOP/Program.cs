using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_string_and_print_values_using_FORLOOP
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

            //Print values using for loop
            for (int i = 0; i < data.Count; i++)
            {
                Console.WriteLine(data[i]);
            }
            Console.ReadLine();
        }
    }
}
