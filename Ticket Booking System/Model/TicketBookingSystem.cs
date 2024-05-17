using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_Booking_System.Repository;
using Ticket_Booking_System.Service;

namespace Ticket_Booking_System.Model
{

    internal class TicketBookingSystem:BookingSystem
    {
       
        private string event_name;
        private string date;
        private string time;
        private int total_seats;
        private float ticket_price;
        private string event_type;
        private string venue_name;
        private Event[] events;

       

        public string EventName
        {
            get { return event_name; }
            set { event_name = value; }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        public int TotalSeats
        {
            get { return total_seats;}
            set { total_seats = value; }
        }

        public float TicketPrice
        {
            get { return ticket_price; }
            set { ticket_price = value; }
        }

        public string EventType
        {
            get { return event_type; }
            set { event_type = value; }
        }

        public string VenueName
        {
            get { return venue_name; }
            set { venue_name = value; }
        }

        public TicketBookingSystem(string eventname, string date,string time,string eventType, int totalseats, string venuename, float ticketprice) 
        {
            this.event_name = eventname;
            this.event_type = eventType;
            this.total_seats = totalseats;
            this.ticket_price = ticketprice;
            this.date = date;
            this.time = time;
            this.venue_name = venuename;
            events = new Event[10];
        }

        private static IEventServiceProvider eventServiceProvider;
        private static IBookingSystemServiceProvider bookingSystemServiceProvider;

        public TicketBookingSystem()
        {
            eventServiceProvider = new EventServiceProviderImpl();
            bookingSystemServiceProvider = new BookingSystemServiceProviderImpl();
        }

        public override void create_event(TicketBookingSystem ticketBookingSystem)
        {
            Console.WriteLine(ticketBookingSystem.create_event);
        }

        public override void display_event_details(Event @event)
        {
            Console.WriteLine(@event);
        }

        public override void book_tickets(Event @event,Booking booking)
        {
            for (int i = 0; i < booking.NumTickets.Length; i++)
            {
                if (booking.NumTickets[i] <= @event.AvailableSeats)
                {
                    @event.AvailableSeats -= booking.NumTickets[i];
                    Console.WriteLine($"{booking.NumTickets[i]} tickets booked successfully!");
                }
                else
                {
                    Console.WriteLine($"Tickets sold out!");
                }
                Console.WriteLine($"Total booking cost: {booking.TotalCost}");
            }
        }

        public override void cancel_tickets(Event @event,Booking booking)
        {
            for (int i = 0; i < booking.NumTickets.Length; i++)
            {
                @event.AvailableSeats += booking.NumTickets[i];
                Console.WriteLine($"{booking.NumTickets[i]} ticket canceled successfully!");
            }
        }   

        public override void getAvailableNoOfTickets(Event @event)
        {
            Console.WriteLine(@event.AvailableSeats);
        }










    }
}
