using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTask
{
    class Customer : ICustomer
    {
        private string _name;
        private double _purchases;

        public Customer(string name, double purchases)
        {
            Name = name;
            Purchases = purchases;
        }

        public string Name { get => _name; set => _name = value; }
        public double Purchases { get => _purchases; set => _purchases = value; }

        public override string ToString()
        {
            return $"Customer name: {this.Name}\tPurchases: {this.Purchases:F2} €\tBonus: {this.GetBonus():F2} €";
        }

        public Object GetCustomer(string name)
        {
            if (this.Name == name)
                return this;
            else
                return null;
        }

        public double GetBonus()
        {
            if (this.Purchases > 2000)
            {
                return 0.05 * this.Purchases;
            }
            else if (this.Purchases > 1000)
            {
                return 0.03 * this.Purchases;
            }
            else
            {
                return 0.02 * this.Purchases;
            }
        }
    }
}