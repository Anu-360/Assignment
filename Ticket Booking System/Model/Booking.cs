using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_Booking_System.Repository;


namespace Ticket_Booking_System.Model
{
    internal class Booking
    {
        private static int nextBookingId = 550;
        private int bookingId;
        private Customer[] customers;
        private Event Event;
        private int[] num_tickets;
        private decimal total_cost;
        private DateTime booking_date;

        public int BookingId
        {
            get { return bookingId; }
            set { bookingId = value; }
        }

        public Customer[] Customers
        {
            get { return customers; }
            set { customers = value; }
        }
        public Event _event
        {
            get { return Event; }
            set { Event = value; }
        }
        public int[] NumTickets
        {
            get { return num_tickets; }
            set { num_tickets = value; }

        }
        public decimal TotalCost
        {
            get { return total_cost; }
            set { total_cost = value; }
        }
        public DateTime BookingDate
        {
            get { return booking_date.Date; }
            set { booking_date = value; }
        }

        public Booking()
        {
            BookingId = nextBookingId++;
            BookingDate = DateTime.Now;
        }
        public Booking(Customer[] customers, Event @event, int[] numtickets, decimal totalcost)
        {

            BookingId = nextBookingId++;
            Customers = customers;
            Event = @event;
            NumTickets = numtickets;
            TotalCost = totalcost;
            BookingDate = DateTime.Now;

        }
        public decimal calculate_booking_cost(int num_tickets, Event @event)
        {
            decimal Booking_cost = num_tickets * @event.TicketPrice;
            return Booking_cost;
        }

        public void book_tickets(Event @event)
        {
            if (NumTickets.Length != Customers.Length)
            {
                Console.WriteLine("Error: Number of tickets does not match the number of customers");
                return;
            }

            if (NumTickets.Length == 0)
            {
                Console.WriteLine("No tickets to book.");
                return;
            }

            for (int i = 0; i < NumTickets.Length; i++)
            {
                if (NumTickets[i] <= Event.AvailableSeats)
                {
                    Event.AvailableSeats -= NumTickets[i];
                    Console.WriteLine($"{NumTickets[i]} tickets booked successfully for customer {Customers[i].CustomerName}!");
                }
                else
                {
                    Console.WriteLine($"Not enough seats available for customer {Customers[i].CustomerName}!");
                }
            }

            Console.WriteLine($"Total booking cost: {TotalCost}");
        }



        public void cancel_booking(Event @event)
        {
            if (NumTickets.Length == 0)
            {
                Console.WriteLine("No tickets to cancel.");
                return;
            }

            for (int i = 0; i < NumTickets.Length; i++)
            {
                Event.AvailableSeats += NumTickets[i];
                Console.WriteLine($"{NumTickets[i]} ticket canceled successfully!");
            }
        }
    


        public int getAvailableNoOfTickets(Event @event)
        {
            return @event.AvailableSeats;
        }

        //public void getEventDetails(Event @event,Event.EventDateTime eventDateTime)
        //{
        //    Console.WriteLine($"Event Name:{@event.EventName}\n Event Date:{eventDateTime.EventDate}\n Event Date:{eventDateTime.EventTime}\n  Event Type:{@event.EventType}\n Seats Capacity:{@event.TotalSeats}\n Available Seats:{@event.AvailableSeats}");
        //}
        public void getEventDetails(Event @event)
        {
            @event.display_event_details(@event);
        }
    }
}
 


