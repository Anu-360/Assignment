using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Booking_System.Model
{
    internal class Sport_abstraction:Event_abstraction
    {
        private string sportName;
        private string teamsName;

        public string SportName
        {
            get { return sportName; }
            set { sportName = value; }
        }

        public string TeamsName
        {
            get { return teamsName; }
            set
            {
                if (value.Contains("vs"))
                {
                    teamsName = value;
                }
                else
                {
                    Console.WriteLine("Invalid Format");
                }
            }
        }
        public Sport_abstraction(string eventname, EventType eventType, string eventdate, string eventtime, int totalseats, int availableseats, string venuename, decimal ticketprice, Type type, string artist) : base(eventname, eventType, eventdate, eventtime, totalseats, availableseats, venuename, ticketprice)
        {
            SportName = sportName;
            TeamsName = teamsName;

        }
        public override void DisplayEventDetails()
        {
            Console.WriteLine($"Sports Name: {SportName}\n Teams Name:{TeamsName}");
        }
    }
}
