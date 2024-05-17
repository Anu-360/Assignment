using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Booking_System.Exceptions
{
    internal class EventNotFoundException:ApplicationException
    {
        public EventNotFoundException() : base("Event not found")
        {
        }
    }
}
