using System;
using System.Collections.Generic;
using System.Text;

namespace TicketPrice
{
    class Customer
    {
        public int age = -1;
        public bool isMtkMember;
        public bool isStudent;
        public bool isConscript;

        public Customer()
        {
            this.age = -1;
            this.isMtkMember = false;
            this.isStudent = false;
            this.isConscript = false;
        }
        public Customer(int age, bool member, bool student, bool conscript)
        {
            this.age = age;
            this.isMtkMember = member;
            this.isStudent = student;
            this.isConscript = conscript;
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0 || value > 120)
                {
                    Console.WriteLine("Ikä pitää olla väliltä 0 - 120.");
                }
                else
                {
                    age = value;
                }
            }
        }
        public bool MtkMember
        {
            get { return isMtkMember; }
            set { isMtkMember = value; }
        }
        public bool Student
        {
            get { return isStudent; }
            set { isStudent = value; }
        }
        public bool Conscript
        {
            get { return isConscript; }
            set { isConscript = value; }
        }
    }
}