using System.Linq.Expressions;
using Ticket_Booking_System.Model; 
using Ticket_Booking_System.Repository;

namespace Ticket_Booking_System.TicketBookingApp
{
    internal class TicketBooking_App
    {
        readonly ITicketBookingRepository _ticketBookingRepository;
        public TicketBooking_App()
        {
            _ticketBookingRepository = new TicketBookingRepository();
        }
        public void Run()
        {
            Console.WriteLine("Welcome to Ticket Booking System!");
            while (true)
            {

                Console.WriteLine("1. Create Event");
                Console.WriteLine("2. Book Tickets");
                Console.WriteLine("3. Cancel Booking");
                Console.WriteLine("4. Get Available Seats");
                Console.WriteLine("5. Get Event Details");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("Enter Event Name:");
                            string EventName = Console.ReadLine();
                            Console.WriteLine("Enter Event Date:");
                            DateTime EventDate = Convert.ToDateTime(Console.ReadLine());
                            Console.WriteLine("Enter Event Time:");
                            TimeSpan EventTime = TimeSpan.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Venue id:");
                            int VenueId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Total seats:");
                            int TotalSeats = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Available seats:");
                            int AvailableSeats = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Ticket Price:");
                            decimal TicketPrice = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Event Type:");
                            string input = Console.ReadLine();
                            EventType type;
                            if (Enum.TryParse(input, true, out type))
                            {
                                Console.WriteLine("Enter the booking id:");
                                int BookingId = Convert.ToInt32(Console.ReadLine());
                                Event newEvent = new Event();
                                _ticketBookingRepository.CreateEvent(newEvent);
                            }

                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine($"Invalid input data: {ex.Message}");
                        }

                        break;
                    case 2:
                        void BookTickets(TicketBookingRepository repository)
                        {
                            try
                            {
                                Console.WriteLine("Enter Event ID:");
                                int eventId = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter Number of Tickets to Book:");
                                int tickets = Convert.ToInt32(Console.ReadLine());

                                bool success = repository.BookTickets(eventId, tickets);
                                if (success)
                                {
                                    Console.WriteLine("Tickets booked successfully.");
                                }
                                else
                                {
                                    Console.WriteLine("Failed to book tickets. Not enough available seats.");
                                }
                            }
                            catch (FormatException ex)
                            {
                                Console.WriteLine($"Invalid input data: {ex.Message}");
                            }
                        }
                        break;
                    case 3:

                        void CancelBooking(TicketBookingRepository repository)
                        {
                            try
                            {
                                Console.WriteLine("Enter Booking ID:");
                                int bookingId = Convert.ToInt32(Console.ReadLine());

                                bool success = repository.CancelBooking(bookingId);
                                if (success)
                                {
                                    Console.WriteLine("Booking cancelled successfully.");
                                }
                                else
                                {
                                    Console.WriteLine("Failed to cancel booking. Booking ID not found.");
                                }
                            }
                            catch (FormatException ex)
                            {
                                Console.WriteLine($"Invalid input data: {ex.Message}");
                            }
                        }
                        break;
                    case 4:

                        void GetAvailableSeats(TicketBookingRepository repository)
                        {
                            try
                            {
                                Console.WriteLine("Enter Event ID:");
                                int eventId = Convert.ToInt32(Console.ReadLine());

                                int availableSeats = repository.GetAvailableSeats(eventId);
                                Console.WriteLine($"Available seats for event {eventId}: {availableSeats}");
                            }
                            catch (FormatException ex)
                            {
                                Console.WriteLine($"Invalid input data: {ex.Message}");
                            }
                        }
                        break;

                    case 5:
                        void GetEventDetails(TicketBookingRepository repository)
                        {
                            try
                            {
                                Console.WriteLine("Enter Event ID:");
                                int eventId = Convert.ToInt32(Console.ReadLine());

                                Event eventDetails = repository.GetEventDetails(eventId);
                                if (eventDetails != null)
                                {
                                    Console.WriteLine($"Event Details for {eventId}:");
                                    Console.WriteLine($"Name: {eventDetails.EventName}");
                                    Console.WriteLine($"Date: {eventDetails.EventDate.ToShortDateString()}");
                                    Console.WriteLine($"Time: {eventDetails.EventTime}");
                                    Console.WriteLine($"Venue ID: {eventDetails.VenueId}");
                                    Console.WriteLine($"Total Seats: {eventDetails.TotalSeats}");
                                    Console.WriteLine($"Available Seats: {eventDetails.AvailableSeats}");
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }

                        }
                        break;

                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Thank You for visiting!");
                        break;
                }
            }
        }
    }
}
    
            

    

