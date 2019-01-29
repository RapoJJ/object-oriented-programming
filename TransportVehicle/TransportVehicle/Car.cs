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
    }
}
