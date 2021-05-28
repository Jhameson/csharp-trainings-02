using System;

using System.Collections.Generic;
using csharp_training.Entities;
using csharp_training.Entities.Enums;

namespace csharp_training
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number os shapes: ");
            int shapes = int.Parse(Console.ReadLine());

            List<Shape> list = new List<Shape>();

            for (int i = 1; i<= shapes; i++)
            {
                Console.WriteLine($"\nDados da figura #{shapes}:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char format = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red)? ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (format == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double heigth = double.Parse(Console.ReadLine());

                    list.Add(new Rectangle(width, heigth, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());

                    list.Add(new Circle(radius, color));
                }

            }
            Console.WriteLine("\nSHAPE AREAS:");
            foreach (Shape sp in list)
            {
                Console.WriteLine(sp.Area().ToString("F2"));
            }
            
        }
    }
}
