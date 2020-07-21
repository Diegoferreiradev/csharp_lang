using System;
using System.Linq;
using System.Collections.Generic;
using ExFunc.Entities;

namespace ExFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Smart TV", 1500.00));
            list.Add(new Product("Tablet", 550.00));
            list.Add(new Product("Headphone", 350.35));
            list.Add(new Product("Smartwatch", 100.00));

            Func<Product, string> func = p => p.Name.ToUpper();

            List<string> result = list.Select(func).ToList();

            foreach (string s in result)
            {
                Console.WriteLine(s);
            }

        }

    }
}
