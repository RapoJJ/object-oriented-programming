using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTask
{
    class Store : ICustomers, IProducts
    {
        private string _name;
        private double _sales;
        private List<Customer> _cList = new List<Customer>();
        private List<Product> _pList = new List<Product>();

        public string Name { get => _name; set => _name = value; }
        public double Sales { get => _sales; set => _sales = value; }
        internal List<Customer> CList { get => _cList; set => _cList = value; }
        internal List<Product> PList { get => _pList; set => _pList = value; }

        public Store()
        {
            Name = string.Empty;
            Sales = 0;
            CList = _cList;
            PList = _pList;
        }
        public Store(string name, double sales, List<Customer> customersList, List<Product> productsList)
        {
            Name = name;
            Sales = sales;
            CList = customersList;
            PList = productsList;
        }

        public override string ToString()
        {
            return $"Store name: {this.Name}\tSales: {this.Sales}\t" +
                $"Customer count: {CList.Count}\t" +
                $"Product count: {PList.Count}";
        }

        public void AddProduct(Product product)
        {
            PList.Add(product);
        }
        public void AddCustomer(Customer customer)
        {
            CList.Add(customer);
        }

        public void PrintProducts()
        {
            foreach (Product p in PList)
            {
                Console.WriteLine($"Product name: {p.Name}\tPrice: {p.Price}\tAmount: {p.Amount}");
            }
        }

        public void PrintCustomers()
        {
            foreach (Customer c in CList)
                Console.WriteLine($"Customer name: {c.Name}\tPurchases: {c.Purchases:F2} €\tBonus: {c.GetBonus():F2} €");
        }
    }
}