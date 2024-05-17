using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_Booking_System.Model;

namespace Ticket_Booking_System.Service
{
    internal interface IBookingSystemServiceProvider
    {
        void CalculateBookingCost(int[] numTickets);
        void BookTickets(string eventName, int[] numTickets, List<Customer> arrayOfCustomer);
        void CancelBooking(int bookingId);
        Booking GetBookingDetails(int bookingId);
    }
}
