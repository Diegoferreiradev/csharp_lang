using GenericsPart03.Entities;
using System;

namespace GenericsPart03
{
    class Program
    {
        static void Main(string[] args)
        {
            //string a = "Maria";
            //string b = "Diego";

            //// Console.WriteLine(a.Equals(b));

            //Console.WriteLine(a.GetHashCode());
            //Console.WriteLine(b.GetHashCode());

            Client c1 = new Client() { Name = "Diego", Email = "diegotestes@gmail.com" };
            Client c2 = new Client() { Name = "Maria", Email = "mariaseverina@gmail.com" };

            Console.WriteLine(c1.Equals(c2));

            Console.WriteLine(c1.GetHashCode());
            Console.WriteLine(c2.GetHashCode());
        }
    }
}
