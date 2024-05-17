using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Booking_System.Model
{
    internal class Movie:Event 
    {
        public enum Genre {
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

        //public Movie(string eventname, EventType eventType, int totalseats, int availableseats, string venuename, decimal ticketprice, Genre genre,string actorname,string actressname):base(eventname,eventType,totalseats,availableseats,venuename,ticketprice)
        //{
        //    _genre = genre;
        //    ActorName = actorname;
        //    ActressName = actressname;

        //}
        public Movie()
        {

        }

        public void display_movie_details(Genre genre,string actorname,string actressname)
        {
            Console.WriteLine($"Movie Details!\n Genre of the Movie:{_genre}\n Actor Name:{ActorName}\n Actress Name:{ActressName}");
        }
    }
}
