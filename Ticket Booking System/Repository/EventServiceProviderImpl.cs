using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_Booking_System.Model;
using Ticket_Booking_System.Service;

namespace Ticket_Booking_System.Repository
{
    internal class EventServiceProviderImpl:IEventServiceProvider
    {
        private List<Event> events;

        public EventServiceProviderImpl()
        {
            events = new List<Event>();
        }

        public Event CreateEvent(Event newEvent)
        {
            if(newEvent == null)
            {
                throw new ArgumentNullException();
            }
            events.Add(newEvent);
            return newEvent;
        }

        public Event[] GetEventDetails()
        {
            return events.ToArray();
        }

        public int GetAvailableNoOfTickets()
        {
            int availableTickets = 0;
            foreach (Event ev in events)
            {
                availableTickets += ev.AvailableSeats;
            }
            return availableTickets;
        }
    }
}

