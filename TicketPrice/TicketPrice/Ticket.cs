using System;
using System.Collections.Generic;
using System.Text;

namespace TicketPrice
{
    class Ticket
    {
        private double price;
        public bool isTicketPrice;


        public Ticket()
        {
            this.price = 16.00;
            this.isTicketPrice = false;
        }

        public double TicketCalculator(Customer customer)
        {
            if (customer.age < 7 )
            {
                isTicketPrice = true;
                return price - price * 1;
            }
            else if (customer.age > 65)
            {
                isTicketPrice = true;
                return price - price * 0.5;
            }
            else if (customer.age >= 7 && customer.age <= 15)
            {
                isTicketPrice = true;
                return price - price * 0.5;
            }
            else
            {
                if (customer.isConscript)
                {
                    return price - price * 0.50;
                }
                else if (customer.isMtkMember && customer.isStudent)
                {
                    return price - price * 0.60;
                }
                else if (customer.isStudent)
                {
                    return price - price * 0.45;
                }
                else if (customer.isMtkMember)
                {
                    return price - price * 0.15;
                }
                else
                    return price;
            }
        }
    }
}