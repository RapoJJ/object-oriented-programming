using System;
using System.Collections.Generic;
using System.Text;

namespace TicketPrice
{
    class Customer
    {
        public double ticketPrice = 16;
        public int age;
        public bool isMtkMember;
        public bool isStudent;
        public bool isConscript;

        public Customer()
        {
            this.age = 0;
            this.isMtkMember = true;
            this.isStudent = true;
            this.isConscript = true;
        }
        public Customer(int age, bool member, bool student, bool conscript)
        {
            this.age = age;
            this.isMtkMember = member;
            this.isStudent = student;
            this.isConscript = conscript;
        }

        public void TicketCalculator()
        {
            double discount = 0;

            if (this.age < 7)
            {
                discount = 1;
            }
            else if (this.age > 65)
            {
                discount = 0.5;
            }
            else if (this.age >= 7 && this.age <= 15)
            {
                discount = 0.5;
            }
            else
            {
                if (this.isConscript)
                {
                    discount = 0.45;
                }
                else if (this.isMtkMember && this.isStudent)
                {
                    discount = 0.60;
                }
                else if (this.isStudent)
                {
                    discount = 0.45;
                }
                else if (this.isMtkMember)
                {
                    discount = 0.15;
                }
            }
            this.ticketPrice = ticketPrice - ticketPrice * discount;
        }
    }
}