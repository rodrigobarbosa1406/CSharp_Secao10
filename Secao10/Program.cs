using System;
using System.Collections.Generic;
using System.Globalization;
using Secao10.Entities;

namespace Secao10
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Qual exercício você quer acessar?");
            Console.WriteLine();

            Console.Write("Herança e polimorfismo (1) ou abstração (2): ");
            int n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Exercicio01();
            }
            else
            {
                Exercicio02();
            }
        }

        public static void Exercicio01()
        {
            List<Product> product = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");

                Console.Write("Common, used or imported (c/u/i)? ");
                char classProduct = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (classProduct == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());

                    product.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (classProduct == 'u')
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

        public static void Exercicio02()
        {
            List<TaxPayer> taxPayers = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");

                Console.Write("Individual or company (i/c)? ");
                char classPayer = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());

                if (classPayer == 'i')
                {
                    Console.Write("Health Expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());

                    taxPayers.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    taxPayers.Add(new Company(name, anualIncome, numberOfEmployees));
                }

                Console.WriteLine();
            }

            Console.WriteLine("TAXEX PAID:");

            double sum = 0.0;

            foreach (TaxPayer taxPayer in taxPayers)
            {
                Console.WriteLine(taxPayer.ToString());
                sum += taxPayer.Tax();
            }

            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
