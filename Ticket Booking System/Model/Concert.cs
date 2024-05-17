using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Booking_System.Model
{
    internal class Concert:Event
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
            get {return type;}
            set { type = value;}
        }
        public string Artist
        {
            get { return artist;}
            set { artist = value;}
        }
        public Concert()
        {

        }
        //public Concert (string eventname, EventType eventType, int totalseats, int availableseats, string venuename, decimal ticketprice,Type type,string artist):base(eventname, eventType, totalseats, availableseats, venuename, ticketprice)
        //{
        //    _type= type;
        //    Artist = artist;
        //}
        public void display_concert_details(Concert concert)
        {
            Console.WriteLine($"Concert Details!\n Concert Type:{_type}\n Artist:{Artist}");
        }
    }
}
