using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Booking_System.Exceptions
{
    internal class InvalidBookingIdException:ApplicationException
    {
        public InvalidBookingIdException() : base("Invalid Booking ID")
        {
        }
    }
}
