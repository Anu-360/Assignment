using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Booking_System.Model
{
    internal class Customer
    {
        private string customer_name;
        private string email;
        private BigInteger phone_number;

        public string CustomerName
        {
            get { return customer_name; }
            set { customer_name = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public BigInteger PhoneNumber
        {
            get { return phone_number; }
            set { phone_number = value; }
        }
        public Customer(string customername, string email, BigInteger phonenumber)
        {
            customer_name = customername;
            this.email = email;
            phone_number = phonenumber;
        }
        public void display_customer_details(Customer customer)
        {
            Console.WriteLine($"Customer Details!\n Customer Name:{customer_name}\n Email Address:{email}\n Phone Number:{phone_number}");
        }
    }
}

