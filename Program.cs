using ProductType.Entities;
using System;
using System.Collections.Generic;

namespace ProductType
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> productList = new List<Product>();
            int qty;

            Console.WriteLine("How many products will be inserted ?");
            qty = int.Parse(Console.ReadLine());

            for (int control = 0; control < qty; control++)
            {
                string name;
                double price;
                double fee;
                DateTime manufacture;
                string type;

                Console.WriteLine("Product Info.");
                Console.Write("I - Imported / N - Normal / U - Used: ");
                type = Console.ReadLine().ToLower();

                if(type == "n")
                {
                    Console.Write("Product name: ");
                    name = Console.ReadLine();

                    Console.Write("Price: ");
                    price = int.Parse(Console.ReadLine());

                    Product p = new Product(name, price);
                    productList.Add(p);
                }
                else if(type == "u")
                {
                    Console.Write("Product name: ");
                    name = Console.ReadLine();

                    Console.Write("Price: ");
                    price = int.Parse(Console.ReadLine());

                    Console.Write("Date Produced (dd/mm/yyyy): ");
                    manufacture = DateTime.Parse(Console.ReadLine());

                    UsedProduct u = new UsedProduct(name,price,manufacture);
                    productList.Add(u); 
                }
                else if(type == "i")
                {
                    Console.Write("Product name: ");
                    name = Console.ReadLine();

                    Console.Write("Price: ");
                    price = int.Parse(Console.ReadLine());

                    Console.WriteLine("Extras fees: ");
                    fee = double.Parse(Console.ReadLine());

                    ImportProduct i = new ImportProduct(name, price, fee);
                    productList.Add(i);
                }
            }

            Console.WriteLine("Price Tags");

            foreach (Product item in productList)
            {
                Console.WriteLine();
                Console.WriteLine(item.PriceTag());
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
