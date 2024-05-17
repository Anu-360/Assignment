using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Booking_System.Model
{
    internal class Sports : Event
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

        //public Sports(string eventname, EventType eventType, int totalseats, int availableseats, string venuename, decimal ticketprice,string sportName,string teamsName):base(eventname, eventType, totalseats, availableseats, venuename, ticketprice)
        //{
        //    SportName=sportName;
        //    TeamsName=teamsName;
        //}
        public Sports()
        {

        }

        public void display_sport_details(Sports sports)
        {
            Console.WriteLine($"Sports Name: {SportName}\n Teams Name:{TeamsName}");
        }
        }
    }


