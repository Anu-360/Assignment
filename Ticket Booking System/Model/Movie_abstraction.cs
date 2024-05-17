using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Booking_System.Model
{
    internal class Movie_abstraction:Event_abstraction
    {
        public enum Genre
        {
            Action,
            Comedy,
            Horror
        }
        private Genre genre;
        private string actorName;
        private string actressName;

        public Genre _genre
        {
            get { return genre; }
            set { genre = value; }
        }
        public string ActorName
        {
            get { return actorName; }
            set { actorName = value; }
        }

        public string ActressName
        {
            get { return actressName; }
            set { actressName = value; }
        }

        public Movie_abstraction(string eventname, EventType eventType,string eventdate,string eventtime,int totalseats, int availableseats, string venuename, decimal ticketprice, Genre genre, string actorname, string actressname) : base(eventname, eventType,eventdate,eventtime, totalseats, availableseats, venuename, ticketprice)
        {
            _genre = genre;
            ActorName = actorname;
            ActressName = actressname;

        }
        public override void DisplayEventDetails()
        {
            Console.WriteLine($"Movie Details!\n Genre of the Movie:{_genre}\n Actor Name:{ActorName}\n Actress Name:{ActressName}");
        }
    }
}
