using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_list_of_customer_using_3_loops
{
    class Customer
    {
        public int id;
        public string name;
        public int points;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer[] customer = new Customer[]
                {
                    new Customer() { id = 101, name ="jeevitha", points =90},
                    new Customer() { id = 102, name ="pavana",points=60},
                    new Customer() { id = 103, name ="john",points=96},
                    new Customer() { id = 104, name ="johney",points=45},
                    new Customer() { id = 105, name ="riya",points=78}
                };
            Console.WriteLine("**********************************************");
                
            //using for loop
            for (int i = 0; i < customer.Length; i++)
            {
                if (customer[i].points >= 30)
                    Console.WriteLine($"id={customer[i].id},name={customer[i].name},Points={customer[i].points}");
            }
            Console.WriteLine("**************************************************");
            //using foreach
            foreach (var e in customer)
            {
                if (e.points >= 30)
                    Console.WriteLine($"id={e.id},name={e.name},Points{e.points}");
            }
            Console.WriteLine("*****************************************************");
            //using lamda expression

            customer.ToList().Where(e => e.points >= 30).ToList().ForEach(e => Console.WriteLine($"id={e.id},name={e.name},Points{e.points}"));
            Console.ReadLine();
        }
    }
}
