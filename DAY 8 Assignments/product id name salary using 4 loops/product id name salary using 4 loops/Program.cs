using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_id_name_salary_using_4_loops
{

    class Product
    {
        public int Id;
        public string Name;
        public int Price;
        public string Brand;
    }
    internal class Program
    {


        static void Main(string[] args)
        {
          List<Product> product = new List<Product>
          {
                    new Product() { Id = 101, Name ="book", Price =30, Brand="Pragathi"},
                    new Product() { Id = 102, Name ="fan",Price=1000, Brand="USHA"},
                    new Product() { Id = 103, Name ="chocolate",Price=100, Brand="Dairymilk"},
                    new Product() { Id = 104, Name ="pen",Price=10, Brand="Cello"},
                    new Product() { Id = 105, Name ="watch",Price=2000, Brand="Fastrack"}
                    };
            Console.WriteLine("******************************************************************");
            //price is >500 using FORLOOP

            for (int i = 0; i < product.Count; i++)
            {
                if (product[i].Price > 500)
                    Console.WriteLine($"name={product[i].Name},Brand={product[i].Brand}");

            }
            Console.WriteLine("********************************************************************");
            //price is >500 using FOREACH LOOP
            foreach (var e in product)
            {
                if (e.Price > 500)
                    Console.WriteLine($"Name={e.Name},Brand={e.Brand}");
            }
            Console.WriteLine("**********************************************************");
            //price is >500 using LAMBDA EXPRESSION
            product.ToList().Where(e => e.Price > 500).ToList().ForEach(e => Console.WriteLine($"Name={e.Name},Brand={e.Brand}"));

            Console.WriteLine("**********************************************************");
            //price is >500 using LINQ QUERY
            var result=from e in product
                       where e.Price > 500
                       select e;
            result.ToList().ForEach(e => Console.WriteLine($"Name={e.Name}, Brand={e.Brand}"));
            Console.ReadLine();
        }
    }
    }

    
        
