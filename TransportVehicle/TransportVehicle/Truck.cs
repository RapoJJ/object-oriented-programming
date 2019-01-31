using System;
using System.Collections.Generic;
using System.Text;

namespace TransportVehicle
{
    class Truck : Car
    {
        protected int loadWeight;
        protected int fuelConsumptionPerKG;
        public Truck()
        {
            loadWeight = 0;
            fuelConsumptionPerKG = 0;
        }
        public Truck(double engine, string model, int doorAmount, string type,
                     string brand, int yearModel, int price, int loadWeight, int fuelConsumptionPerKG):
            base(engine, model, doorAmount, type, brand, yearModel, price)
        {
            this.loadWeight = loadWeight;
            this.fuelConsumptionPerKG = fuelConsumptionPerKG;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Load Weight: {this.loadWeight}\t" +
                $"Fuel Consumption per KG: {this.fuelConsumptionPerKG}\t" +
                $"Fuel Consumption: {this.FuelConsumption()}");
        }
        public override string ToString()
        {
            return base.ToString() + $"Load Weight: {this.loadWeight}\t" +
                $"Fuel Consumption per KG: {this.fuelConsumptionPerKG}\t" +
                $"Fuel Consumption: {this.FuelConsumption()}";
        }
        public int FuelConsumption()
        {
            return this.loadWeight * this.fuelConsumptionPerKG;
        }
    }
}
