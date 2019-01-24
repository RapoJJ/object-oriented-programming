using System;
using System.Collections.Generic;
using System.Text;

namespace TicketPrice
{
    class Ticket
    {
        private double _price;
        public bool isTicketPrice;

        public Ticket()
        {
            this._price = 16.00;
            this.isTicketPrice = false;
        }

        public double TicketCalculator(Customer customer)
        {
            if (customer.age < 7 )
            {
                Console.WriteLine("Customer is under 7 years old, ticket discount is 100 %.");
                isTicketPrice = true;
                return _price - _price * 1;
            }
            else if (customer.age > 65)
            {
                Console.WriteLine("Customer is over 65 years old, ticket discount is 50 %.");
                isTicketPrice = true;
                return _price - _price * 0.5;
            }
            else if (customer.age >= 7 && customer.age <= 15)
            {
                Console.WriteLine("Customer is between 7 and 15 years old, ticket discount is 50 %.");
                isTicketPrice = true;
                return _price - _price * 0.5;
            }
            else
            {
                if (customer.isConscript)
                {
                    return _price - _price * 0.50;
                }
                else if (customer.isMtkMember && customer.isStudent)
                {
                    return _price - _price * 0.60;
                }
                else if (customer.isStudent)
                {
                    return _price - _price * 0.45;
                }
                else if (customer.isMtkMember)
                {
                    return _price - _price * 0.15;
                }
                else
                    return _price;
            }
        }
    }
}