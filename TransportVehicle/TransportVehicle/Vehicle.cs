using System;
using System.Collections.Generic;
using System.Text;

namespace TransportVehicle
{
    abstract class  Vehicle
    {
        protected string type;
        protected string brand;
        protected int yearModel;
        protected int price;

        public Vehicle()
        {
            type = string.Empty;
            brand = string.Empty;
            yearModel = 1900;
            price = 0;
        }
        public Vehicle(string type, string brand, int year, int price)
        {
            this.type = type;
            this.brand = brand;
            this.yearModel = year;
            this.price = price;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Vehicle type: {this.type}\n" +
                $"Brand: {this.brand}\n" +
                $"Model year: {this.yearModel}\n" +
                $"Price: {this.price}");
        }
        public override string ToString()
        {
            return $"Vehicle type: {this.type}\n" +
                $"Brand: {this.brand}\n" +
                $"Model year: {this.yearModel}\n" +
                $"Price: {this.price}";
        }
    }
}