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
            Console.WriteLine($"Vehicle type: {this.type}\t" +
                $"Brand: {this.brand}\t" +
                $"Model year: {this.yearModel}\t" +
                $"Price: {this.price}");
        }
        public override string ToString()
        {
            return $"Vehicle type: {this.type}\t" +
                $"Brand: {this.brand}\t" +
                $"Model year: {this.yearModel}\t" +
                $"Price: {this.price}";
        }
    }
}