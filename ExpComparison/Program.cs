using ExpComparison.Entities;
using System;
using System.Collections.Generic;

namespace ExpComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Smart TV", 1500.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));
            list.Add(new Product("Smartphone", 1000.00));
            list.Sort(CompareProducts);

            foreach (Product product in list)
            {
                //Console.WriteLine(product);
                Console.WriteLine($"Product: {product.Name}, R$ {product.Price}");
            }
        }

        static int CompareProducts(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
    }
}
