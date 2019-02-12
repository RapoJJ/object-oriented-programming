using System;
using System.Collections.Generic;
using System.Text;

namespace PolygonsTask
{
    abstract class Shape
    {
        private string _type;
        private string _color;
        abstract public double Area();
        abstract public string GetInfo();

        public string Type { get => _type; set => _type = value; }
        public string Color { get => _color; set => _color = value; }

        public Shape(string type, string color)
        {
            Type = type;
            Color = color;
        }

        public string GetColor()
        {
            return this.Color;
        }
    }
}
