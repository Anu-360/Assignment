using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Booking_System.Model
{
    internal class Concert_abstraction:Event_abstraction
    {
        public enum Type
        {
            Theatrical,
            Classical,
            Rock,
            Recital
        }
        private string artist;
        private Type type;

        public Type _type
        {
            get { return type; }
            set { type = value; }
        }
        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }

        public Concert_abstraction(string eventname, EventType eventType, string eventdate, string eventtime, int totalseats, int availableseats, string venuename, decimal ticketprice, Type type, string artist) : base(eventname, eventType, eventdate, eventtime, totalseats, availableseats, venuename, ticketprice)
        {
            _type = type;
            Artist = artist;
        }
        public override void DisplayEventDetails()
        {
            Console.WriteLine($"Concert Details!\n Concert Type:{_type}\n Artist:{Artist}");
        }
    }
}
