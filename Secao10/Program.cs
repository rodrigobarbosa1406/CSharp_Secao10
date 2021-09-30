using System;
using System.Collections.Generic;
using Secao10.Entities;

namespace Secao10
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List <Product> product = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");

                Console.Write("Common, used or imported (c/u/i)? ");
                char typeProduct = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (typeProduct == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());

                    product.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (typeProduct == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    product.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    product.Add(new Product(name, price));
                }

                Console.WriteLine();
            }

            Console.WriteLine("PRICE TAGS:");

            foreach (Product prod in product)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
