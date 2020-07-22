﻿using System.Globalization;

namespace ExeLinq.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}, R$ {Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
