using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_Booking_System.Model;
using Ticket_Booking_System.Service;

namespace Ticket_Booking_System.Repository
{
    internal class BookingSystemServiceProviderImpl : IBookingSystemServiceProvider
    {
        private List<Booking> bookings = new List<Booking>();
        private int nextBookingId = 1;

        public void CalculateBookingCost(int[] numTickets)
        {
          
            Console.WriteLine("Booking cost calculated");
        }

        public void BookTickets(string eventName, int[] numTickets, List<Customer> arrayOfCustomer)
        {
            var newBooking = new Booking
            {
                BookingId = nextBookingId++,
                //EventName = eventName,
                NumTickets = numTickets
            };

            bookings.Add(newBooking);
            Console.WriteLine("Tickets booked successfully");
        }

        public void CancelBooking(int bookingId)
        {
            
            var bookingToRemove = bookings.Find(b => b.BookingId == bookingId);
            if (bookingToRemove != null)
            {
                bookings.Remove(bookingToRemove);
                Console.WriteLine("Booking cancelled successfully");
            }
            else
            {
                Console.WriteLine("Booking not found");
            }
        }

        public Booking GetBookingDetails(int bookingId)
        {
          
            var booking = bookings.Find(b => b.BookingId == bookingId);
            return booking;
        }
    }
}

