using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Booking_System.Model
{
    abstract class Event_abstraction
    {
        public enum EventType
        {
            Movie,
            Sports,
            Concert
        }

            private string event_name;
            private string event_date;
            private string event_time;
            private string venue_name;
            private int total_seats;
            private int available_seats;
            private decimal ticket_price;
            private EventType event_type;

            public string EventName
            {
                get { return event_name; }
                set { event_name = value; }
            }
         
            public string EventDate
            {
                 get { return event_date; }
                 set { event_date = value; }
            }

             public string EventTime
             {
                  get { return event_time; }
                  set { event_time = value; }
             }

           
            public string VenueName
            {
                get { return venue_name; }
                set { venue_name = value; }
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

        public EventType Event_Type
        {
            get { return event_type; }
            set { event_type = value; }
        }

        public Event_abstraction(string eventname, EventType eventType,string eventdate,string eventtime, int totalseats, int availableseats, string venuename, decimal ticketprice)
            {
                EventName = eventname;
                Event_Type = eventType;
                EventDate = eventdate;
                EventTime = eventtime;
                TotalSeats = totalseats;
                AvailableSeats = availableseats;
                VenueName = venuename;
                TicketPrice = ticketprice;
            }
        public abstract void DisplayEventDetails();
        }
}
