using System;
using System.Linq;
using Linq01.Entities;
using System.Collections.Generic;

namespace Linq01
{
    class Program
    {
        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };
            

            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "Desktop", Price = 2300.0, Category = c1 },
                new Product() { Id = 4, Name = "Notebook", Price = 3000.0, Category = c1 },
                new Product() { Id = 5, Name = "Smartwatch", Price = 100.0, Category = c3 },
                new Product() { Id = 6, Name = "Headphone", Price = 350.0, Category = c3 },
                new Product() { Id = 7, Name = "Pencil", Price = 3.50, Category = c3 },
                new Product() { Id = 8, Name = "TV", Price = 1899.0, Category = c3 },
                new Product() { Id = 9, Name = "Printer", Price = 399.0, Category = c2 },
                new Product() { Id = 10, Name = "Tablet", Price = 355.0, Category = c2 },
                new Product() { Id = 11, Name = "Macbook", Price = 4300.0, Category = c2 },
                new Product() { Id = 12, Name = "Cubo", Price = 1899.0, Category = c3 },
                new Product() { Id = 13, Name = "Level", Price = 70.0, Category = c3 },
            };

            Console.WriteLine();
            Console.WriteLine("TIER 1 AND PRICE < 900");
            var result = products.Where(p => p.Category.Tier == 1 && p.Price < 900);

            foreach (Product item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("NAMES OF PRODUCTS FROM TOOLS");
            var result2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);

            foreach (var item2 in result2)
            {
                Console.WriteLine(item2);
            }

            Console.WriteLine();
            Console.WriteLine("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT");
            var result3 = products.Where(p => p.Name[0] == 'C').Select( p => new { p.Name, p.Price, CategoryName = p.Category.Name });

            foreach (var item3 in result3)
            {
                Console.WriteLine(item3);
            }


            Console.WriteLine();
            Console.WriteLine("TIER 1 ORDER BY PRICE THEN BY NAME");
            var result4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);

            foreach (var item4 in result4)
            {
                Console.WriteLine(item4);
            }

            Console.WriteLine();
            var result5 = result4.Skip(2).Take(4);

            foreach (var item in result5)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            var result6 = products.First();
            Console.WriteLine("First test1: " + result6);

            Console.WriteLine();
            var result7 = products.Where(p => p.Price > 4500.0).FirstOrDefault();
            Console.WriteLine("First or default test2" + result7);

            Console.WriteLine();
            var result8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or Default test3 " + result8);
        }
    }
}
