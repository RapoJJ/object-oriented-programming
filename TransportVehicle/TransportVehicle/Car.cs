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
            doorAmount = 5;
        }
        public Car(double engine, string model, int doorAmount, string type, string brand, int yearModel, int price):
            base(type, brand, yearModel, price)
        {
            this.engine = engine;
            this.model = model;
            this.doorAmount = doorAmount;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Engine: {this.engine}\t" +
                $"Model: {this.model}\t" +
                $"Doors: {this.doorAmount}");
        }
        public override string ToString()
        {
            return base.ToString() + $"\nEngine: {this.engine}\t" +
                $"Model: {this.model}\t" +
                $"Doors: {this.doorAmount}";
        }
        public override bool Equals(object obj)
        {
            Car carObj = obj as Car;

            if (carObj == null)
                return false;
            else
            {
                return this.model.Equals(carObj.model) && this.brand.Equals(carObj.brand)
                    && this.doorAmount.Equals(carObj.doorAmount) && this.engine.Equals(carObj.engine)
                    && this.price.Equals(carObj.price) && this.type.Equals(carObj.type)
                    && this.yearModel.Equals(carObj.yearModel);
            }
        }
    }
}