using System;
using System.Collections.Generic;
using System.Globalization;
using Products.Entities;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            double price;
            double customs;
            int N;

            Console.Write("Enter the number of products: ");
            N = int.Parse(Console.ReadLine());
            List<Product> list = new List<Product>();

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, Used or Imported (c / u / i)? ");
                char productType = char.Parse(Console.ReadLine());

                if (productType == 'i' || productType == 'I')
                {
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    Console.Write("Price: ");
                    price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Custom fee: ");
                    customs = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new ImportedProduct(name, price, customs));
                }
                else if (productType == 'c' || productType == 'C')
                {
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    Console.Write("Price: ");
                    price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Product(name, price));
                }
                else
                {
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    Console.Write("Price: ");
                    price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Manufatured date (YYYY/DD/MM): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(name, price, date));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product product in list)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
