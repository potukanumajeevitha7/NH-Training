using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_product_class
{
    internal class Product
    {
        public int Product_ID;
        public string Product_Name;
        public string Product_price;



        public void ReadProduct()
        {
            Console.WriteLine("Enter Product_ID: ");
            Product_ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Product_Name");
            Product_Name = Console.ReadLine();

            Console.WriteLine("Enter Product_price: ");
            Product_price = Console.ReadLine();
        }
        public void PrintProduct()
        {
            Console.WriteLine($"product_ID = {Product_ID},product_Name = {Product_Name}, product_price = {Product_price}");

        }

        static void Main(string[] args)
        {
            Product Product = new Product();
            Product.ReadProduct();
            Product.PrintProduct();

            Console.ReadLine();
        }

 
        }
    }

