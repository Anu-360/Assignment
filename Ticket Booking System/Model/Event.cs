using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Booking_System.Model
{
    public enum EventType
    {
        Movie,
        Sports,
        Concert
    }

    internal class Event
    {
        private static int event_id = 401;
        private string event_name;
        private DateTime event_date;
        private TimeSpan event_time;
        private int venue_id;
        private int total_seats;
        private int available_seats;
        private decimal ticket_price;
        private EventType event_type;
        private int booking_id;

        public int EventId
        {
            get { return event_id; }
            private set { event_id = value; }
        }
        public string EventName
        {
            get { return event_name; }
            set { event_name = value; }
        }

        public DateTime EventDate
        {
            get {return event_date.Date;} 
            set { event_date = value;} 
        }

        public TimeSpan EventTime
        {
            get { return event_time;}
            set { event_time = value;}
        }
        public int VenueId
        {
            get { return venue_id; }
            set { venue_id = value; }
        }

        public int TotalSeats
        {
            get { return total_seats; }
            set { total_seats = value; }
        }

        public int AvailableSeats
        {
            get { return available_seats; }
            set { available_seats = value; }
        }

        public decimal TicketPrice
        {
            get { return ticket_price; }
            set { ticket_price = value; }
        }

        public EventType EventType
        {
            get { return event_type; }
            set { event_type = value; }
        }
        public int BookingId
        {
            get { return booking_id; }
            set { booking_id = value; }
        }
        public Event()
        {

        }
        public Event(string eventname, EventType eventType,DateTime eventdate,TimeSpan eventtime, int totalseats, int availableseats,int venueid, decimal ticketprice,int booking_id)
        {
            event_id++;
            EventId=event_id;
            EventName = eventname;
            EventType = eventType;
            EventDate = eventdate;
            EventTime = eventtime;
            TotalSeats = totalseats;
            AvailableSeats = availableseats;
            VenueId = venueid;
            TicketPrice = ticketprice;
            BookingId = booking_id;
        }
        public void calculate_total_revenue(decimal ticket_price, Booking booking)
        {
            for (int i = 0; i < booking.NumTickets.Length; i++)
            {
                decimal total_revenue = ticket_price * booking.NumTickets[i];
                Console.WriteLine($"Total revenue generated:{total_revenue}");
            }    
           
        }

        public void getBookedNoOfTickets(Booking booking)
        {
            for(int i = 0;i<booking.NumTickets.Length;i++)
            {
               Console.WriteLine($"Tickets booked: {booking.NumTickets[i]}");
            }
          
        }

        public virtual void book_tickets(Booking booking)
        {
            for (int i = 0; i < booking.NumTickets.Length; i++)
            {
                if (booking.NumTickets[i] <= AvailableSeats)
                {
                    AvailableSeats -= booking.NumTickets[i];
                    Console.WriteLine($"{booking.NumTickets[i]} tickets booked successfully!");
                }
                else
                {
                    Console.WriteLine($"Tickets sold out!");
                }
                Console.WriteLine($"Total booking cost: {booking.TotalCost}");
            }

        }
        public void cancel_booking(Booking booking)
        {

            for (int i = 0; i < booking.NumTickets.Length; i++)
            {
                AvailableSeats += booking.NumTickets[i];
                Console.WriteLine($"{booking.NumTickets[i]} ticket canceled successfully!");
            }
        }
        public virtual void display_event_details(Event @event)
        {
            Console.WriteLine($"Event Name:{EventName}\n Event Date:{EventDate}\n Event Time:{EventTime}\n Event Type:{EventType}\n Seats Capacity:{TotalSeats}\n Available Seats:{AvailableSeats}");
        }
    }
}
