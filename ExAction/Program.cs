using System;
using ExAction.Entities;
using System.Collections.Generic;

namespace ExAction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse PAD", 13.50));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 72.80));

            list.ForEach(UpdatePrice);
            foreach (Product item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}
