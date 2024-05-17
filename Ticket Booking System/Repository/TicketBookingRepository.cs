using Ticket_Booking_System.Utility;
using Ticket_Booking_System.Model;
using System.Data.SqlClient;


namespace Ticket_Booking_System.Repository
{
    internal class TicketBookingRepository : ITicketBookingRepository
    {
        SqlConnection sqlConnection = null;
        SqlCommand cmd = null;

        public TicketBookingRepository()
        {
            sqlConnection = new SqlConnection("Server=OBLIVIATE7;Database=TicketBookingSystem;Trusted_Connection=True");
            cmd = new SqlCommand();

        }
        public Event CreateEvent(Event newEvent)
        {

            cmd.CommandText = "INSERT INTO Event(event_name,event_date, event_time, venue_id,total_seats ,available_seats,ticket_price,event_type,booking_id) VALUES(@Name, @Date, @Time,@Venueid, @TotalSeats, @AvailableSeats,@TicketPrice,@Type,@Bookingid)";
            cmd.Parameters.AddWithValue("@Name", newEvent.EventName);
            cmd.Parameters.AddWithValue("@Date", newEvent.EventDate.Date);
            cmd.Parameters.AddWithValue("@Time", newEvent.EventTime);
            cmd.Parameters.AddWithValue("@Venue", newEvent.VenueId);
            cmd.Parameters.AddWithValue("@TotalSeats", newEvent.TotalSeats);
            cmd.Parameters.AddWithValue("@AvailableSeats", newEvent.AvailableSeats);
            cmd.Parameters.AddWithValue("@TicketPrice", newEvent.TicketPrice);
            cmd.Parameters.AddWithValue("@Type", newEvent.EventType);
            cmd.Parameters.AddWithValue("@Bookingid", newEvent.BookingId);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            int eventId = Convert.ToInt32(cmd.ExecuteScalar());
            sqlConnection.Close();


            return newEvent;
        }
        public Event[] GetEventDetails()
        {
            List<Event> events = new List<Event>();
            cmd.CommandText = "SELECT event_name, event_date, event_time, venue_id, total_seats, available_seats, ticket_price, event_type, booking_id FROM Event";
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Event getevent = new Event()
                    {
                        EventName = (string)reader["event_name"],
                        EventDate = (DateTime)reader["event_date"],
                        EventTime = (TimeSpan)reader["event_time"],
                        VenueId = (int)reader["venue_id"],
                        TotalSeats = (int)reader["total_seats"],
                        AvailableSeats = (int)reader["available_seats"],
                        TicketPrice = (int)reader["ticket_price"],
                        EventType = (EventType)reader["event_type"],
                        BookingId = (int)reader["booking_id"]
                    };
                    events.Add(getevent);


                }
            }
            return events.ToArray();
           
        }




    }
}








        

    
