using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Booking_System.Model
{
    abstract class BookingSystem
    {
        public abstract void create_event(TicketBookingSystem ticketBookingSystem);
        public abstract void book_tickets(Event @event,Booking booking);
        public abstract void cancel_tickets(Event @event,Booking booking);
        public abstract void display_event_details(Event @event);
        public abstract void getAvailableNoOfTickets(Event @event);
    }
}
