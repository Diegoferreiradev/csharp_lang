using ExPredicate.Entities;
using System.Collections.Generic;
using System;

namespace ExPredicate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Smartphone", 850.00));
            list.Add(new Product("Smart TV", 1500.00));
            list.Add(new Product("Smartwatch", 100.00));
            list.Add(new Product("Notebook", 3500.00));
            list.Add(new Product("Pencil", 2.50));

            list.RemoveAll(ProductTest);
           // list.RemoveAll(p => p.Price <= 100.0);

            foreach (Product item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.0;
        }
    }
}
