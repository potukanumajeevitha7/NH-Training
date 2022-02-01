using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_seller_class
{
    internal class seller_1
    {
        public int Seller_ID;
        public string Seller_Name;
        public string Seller_Email;



        public void Readseller()
        {
            Console.WriteLine("Enter Seller_ID: ");
            Seller_ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Seller_Name");
            Seller_Name = Console.ReadLine();

            Console.WriteLine("Enter Seller_Email: ");
            Seller_Email = Console.ReadLine();
        }
        public void Printseller()
        {
            Console.WriteLine($"seller_ID = {Seller_ID},seller_Name = {Seller_Name}, Seller_Email = {Seller_Email}");

        }
        static void Main(string[] args)
        {
            seller_1 seller = new seller_1();
            seller.Readseller();
            seller.Printseller();

            Console.ReadLine();
        }
    }
}
