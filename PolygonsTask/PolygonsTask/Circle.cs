using System;
using System.Collections.Generic;
using System.Text;

namespace PolygonsTask
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(string type, string color,double radius)
            :base(type, color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Radius * Radius * Math.PI; 
        }

        public override string ToString()
        {
            return base.ToString() + $"\tRadius: {Radius}\tArea: {Area():F2}";
        }
    }
}