using System;
using System.Collections.Generic;
using System.Text;

namespace PolygonsTask
{
    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(string type, string color, double length, double width)
            : base(type, color)
        {
            Length = length;
            Width = width;
        }

        public override double Area()
        {
            return Length * Width;
        }

        public override string ToString()
        {
            return base.ToString() + $"\tLength: {Length}\tWidth: {Width}\tArea: {Area():F2}";
        }
    }
}