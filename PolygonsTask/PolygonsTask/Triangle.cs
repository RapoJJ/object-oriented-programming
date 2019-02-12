using System;
using System.Collections.Generic;
using System.Text;

namespace PolygonsTask
{
    class Triangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Triangle(string type, string color, double length, double width)
            :base(type, color)
        {
            Length = length;
            Width = width;
        }

        public override double Area()
        {
            return Length * Width / 2;
        }

        public override string ToString()
        {
            return base.ToString() + $"\tLength: {Length}\tWidth: {Width}\tArea: {Area():F2}";
        }
    }
}