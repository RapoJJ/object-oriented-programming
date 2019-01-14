using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyClass
{
    class Company
    {
        public string title;
        public string address;
        public string phoneNr;
        public int income;
        public int expense;


        public Company()
        {
            this.title = "title";
            this.address = "address";
            this.phoneNr = "phoneNr";
            this.income = 0;
            this.expense = 0;
        }

        public Company(string title, string address, string phoneNr, int income, int expense)
        {
            this.title = title;
            this.address = address;
            this.phoneNr = phoneNr;
            this.income = income;
            this.expense = expense;
        }

        public Company(Company previousCompany)
        {
            this.title = previousCompany.title;
            this.address = previousCompany.address;
            this.phoneNr = previousCompany.phoneNr;
            this.income = previousCompany.income;
            this.expense = previousCompany.expense;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Company title: {this.title}");
            Console.WriteLine($"Company address: {this.address}");
            Console.WriteLine($"Company phoneNr: {this.phoneNr}");
            Console.WriteLine($"Company income: {this.income}");
            Console.WriteLine($"Company expense: {this.expense}");
            Console.WriteLine("--------------------------------------------------");
        }
        public void Profit()
        {
            double profit = 100 * (this.income - this.expense) / this.expense;
            Console.Write($"Companys {this.title} profit is {profit} %. ");

            if (profit > 300)
            {
                Console.WriteLine("Companys business is doing well!");
            }
            else if (profit < 100)
            {
                Console.WriteLine("Companys business is doing badly!");
            }
            else
            {
                Console.WriteLine("Companys business is doing satisfactorily.");
            }
            Console.WriteLine("--------------------------------------------------");
        }
    }
}