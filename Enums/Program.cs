using System;
using Enumeradores.Entities;
using Enumeradores.Entities.Enums;

namespace Enumeradores
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1,
                Moment = DateTime.Now,
                Status = OrderStatus.Shipped
            };

            Console.WriteLine(order);

            string txt = OrderStatus.Processing.ToString();

            Console.WriteLine(txt);
        }
    }
}
