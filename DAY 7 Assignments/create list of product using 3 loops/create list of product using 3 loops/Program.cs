using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_list_of_product_using_3_loops
{
    class Product
    {
    
            public int id;
            public string name;
            public int price;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Product[] product = new Product[]
                    {
                    new Product() { id = 101, name ="book", price =30},
                    new Product() { id = 102, name ="fan",price=1000},
                    new Product() { id = 103, name ="chocolate",price=100},
                    new Product() { id = 104, name ="pen",price=10},
                    new Product() { id = 105, name ="watch",price=2000}
                    };
            Console.WriteLine("*****************************************************");
                //using for loop
                for (int i = 0; i < product.Length; i++)
                {
                    if (product[i].price >= 100)
                        Console.WriteLine($"id={product[i].id},name={product[i].name},Price={product[i].price}");
                }
            Console.WriteLine("****************************************************");
                //using foreach
                foreach (var e in product)
                {
                    if (e.price >= 100)
                        Console.WriteLine($"id={e.id},name={e.name},Price{e.price}");
                }
                Console.WriteLine("***************************************************");
                //using lamda expression

                product.ToList().Where(e => e.price >= 100).ToList().ForEach(e => Console.WriteLine($"id={e.id},name={e.name},Price{e.price}"));
                Console.ReadLine();
            }
        }
    }


