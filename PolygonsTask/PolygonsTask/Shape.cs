using System;
using System.Collections.Generic;
using System.Text;

namespace PolygonsTask
{
    abstract class Shape
    {
        public abstract double Area();

        public string Type { get; set; }
        public string Color { get; set; }

        protected Shape(string type, string color)
        {
            Type = type;
            Color = color;
        }

        public string GetColor()
        {
            return this.Color;
        }

        public override string ToString()
        {
            return $"Shape type: {Type}\tColor: {Color}";
        }
    }
}