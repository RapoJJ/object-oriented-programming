using System;
using System.Collections.Generic;
using System.Text;

namespace TransportVehicle
{
    class Car : Vehicle
    {
        protected double engine;
        protected string model;
        protected int doorAmount;

        public Car()
        {
            engine = 2.0;
            model = string.Empty;
            doorAmount = 4;
        }
        public Car(double engine, string model, int doorAmount, string type, string brand, int year, int price):
            base(type, brand, year, price)
        {
            this.engine = engine;
            this.model = model;
            this.doorAmount = doorAmount;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Engine: {this.engine}\n" +
                $"Model: {this.model}\n" +
                $"Doors: {this.doorAmount}");
        }
        public override string ToString()
        {
            return base.ToString() + $"\nEngine: {this.engine}\n" +
                $"Model: {this.model}\n" +
                $"Doors: {this.doorAmount}";
        }
        public override bool Equals(object obj)
        {
            Car carObj = obj as Car;

            if (carObj == null)
                return false;
            else
                return base.Equals((Car)carObj);
        }
    }
}
