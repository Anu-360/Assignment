using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_Booking_System.Model;

namespace Ticket_Booking_System.Service
{
    internal interface IEventServiceProvider
    {
        Event CreateEvent(Event newEvent);
        Event[] GetEventDetails();
        //int GetAvailableNoOfTickets();
    }
}
