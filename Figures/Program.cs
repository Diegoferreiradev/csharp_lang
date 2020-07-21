using System;
using System.Collections.Generic;
using Figures.Entities;
using Figures.Entities.Enums;
using System.Globalization;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            double width;
            double height;
            double radius;
            char figure;
            int N;

            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or Circle (r / c)?");
                figure = char.Parse(Console.ReadLine());
                Console.Write("Color (Black / Blue / Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());


                if (figure == 'r' || figure == 'R')
                {

                    Console.Write("Width: ");
                    width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(width, height, color));
                }
                else
                {   
                    Console.Write("Radius: ");
                    radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Circle(color, radius));
                }

            }
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");
            foreach (Shape shape in list)
            {
                Console.WriteLine($"{shape.Area().ToString("f2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
