using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Booking_System.Model
{
    internal class Venue
    {
        private static int venue_id=101;
        private string venue_name;
        private string address;

        public int VenueId
        {
            get { return venue_id; }
            private set { venue_id = value; }
        }
        public string VenueName
        {
            get { return venue_name; }
            set { venue_name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public Venue(string venuename, string address)
        {
            venue_id++;
            VenueId = venue_id;
            VenueName = venuename;
            Address = address;
        }

        public void display_venue_details(string venuename, string address)
        {
            Console.WriteLine($"Venue Details!\n Venue Name:{venuename}\n Address:{address}");
        }
    }
}
