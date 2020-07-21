using System;
using System.Globalization;

namespace VetorProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Product[] vect = new Product[N];

            for (int i = 0; i < N; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                vect[i] = new Product { Name = name, Price = price };
            }

            double sum = 0.0;
            for (int i = 0; i < N; i++)
            {
                sum += vect[i].Price;
            }

            double avg = sum / N;
            Console.WriteLine($"Average Price =  {avg.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
