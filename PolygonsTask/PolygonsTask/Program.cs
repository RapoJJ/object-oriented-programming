using System;
using System.Collections.Generic;

namespace PolygonsTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>
            {
                new Circle("Circle", "Red", 4),
                new Triangle("Triangle", "Blue",7,4),
                new Rectangle("Rectangle","Green",10,15)
            };

            foreach (var s in shapes)
                Console.WriteLine(s.ToString());
            Console.WriteLine("-------------------");
            Console.WriteLine("Print only Circles");
            foreach (var type in shapes)
            {
                if (type is Circle)
                    Console.WriteLine(type.ToString());
            }
        }
    }
}
