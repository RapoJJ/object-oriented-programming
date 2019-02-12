using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTask
{
    class Product : IProduct
    {
        private string _name;
        private double _price;
        private int _amount;

        public string Name { get => _name; set => _name = value; }
        public double Price { get => _price; set => _price = value; }
        public int Amount { get => _amount; set => _amount = value; }

        public Product(string name, double price, int amount)
        {
            this.Name = name;
            this.Price = price;
            this.Amount = amount;
        }

        public override string ToString()
        {
            return $"Product name: {this.Name}\tPrice: {this.Price:F2} €\tAmount: {this.Amount}\tTotal price: {this.CalculateTotal():F2} €";
        }

        public double CalculateTotal()
        {
            return this.Amount * this.Price;
        }
        public Object GetProduct(string name)
        {
            if (this.Name == name)
                return this;
            else
                return null;
        }
    }
}
