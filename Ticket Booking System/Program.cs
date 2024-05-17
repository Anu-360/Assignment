using Ticket_Booking_System.Exceptions;
using Ticket_Booking_System.Model;
using static Ticket_Booking_System.Model.Event;
using Ticket_Booking_System.Repository;
using Ticket_Booking_System.Service;
using Ticket_Booking_System.TicketBookingApp;

namespace Ticket_Booking_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1: Conditional Statements
            /*In a BookingSystem, you have been given the task is to create a program to book tickets. If available
            tickets more than noOfTicket to book then display the remaining tickets or ticket unavailable */

            //Tasks:
            // 1.Write a program that takes the availableTicket and noOfBookingTicket as input.
            // 2.Use conditional statements(if-else) to determine if the ticket is available or not.
            // 3.Display an appropriate message based on ticket availability.

            //Console.WriteLine("Enter the number of available tickets: ");
            //int availableTicket = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the number of tickets to book: ");
            //int noOfBookingTicket = Convert.ToInt32(Console.ReadLine());

            //if (availableTicket >= noOfBookingTicket)
            //{
               
            //    Console.WriteLine($"{noOfBookingTicket} tickets booked successfully!");
            //}
            //else
            //{
            //    Console.WriteLine($"Tickets sold out!");
            //}
            #endregion

            #region Task 2: Nested Conditional Statements
            /*Create a program that simulates a Ticket booking and calculating cost of tickets. Display tickets options
             such as "Silver", "Gold", "Diamond".Based on ticket category fix the base ticket price and get the user input
             for ticket type and no of tickets need and calculate the total cost of tickets booked.*/

            //Console.WriteLine($"Tickets type available :\n'1:Silver'\n'2:Gold'\n'3:Diamond'");
            //Console.WriteLine($"Enter the type by choosing the options:");
            //int ticketType = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Enter the number of tickets needed: ");
            //int ticketsNeeded = Convert.ToInt32(Console.ReadLine());
            //if (ticketType == 1)
            //{
            //    int silverTicket = ticketsNeeded * 3000;
            //    Console.WriteLine($"Total cost of tickets booked:{silverTicket}");
            //}
            //else if (ticketType == 2)
            //{
            //    int goldTicket = ticketsNeeded * 5000;
            //    Console.WriteLine($"Total cost of tickets booked:{goldTicket}");
            //}
            //else if (ticketType == 3)
            //{
            //    int diamondTicket = ticketsNeeded * 8000;
            //    Console.WriteLine($"Total cost of tickets booked:{diamondTicket}");
            //}
            //else
            //{
            //    Console.WriteLine("Ticket type not available");
            //}
            #endregion

            #region Task 3: Looping
            //From the above task book the tickets for repeatedly until user type "Exit"
        //    string input;
        //    do
        //    {
        //        Console.WriteLine("Book your Tickets!");
        //        string ticketType = "1:Silver\n2:Gold\n3:Diamond";
        //        Console.WriteLine($"Available ticket types:\n{ticketType}\n Choose a ticket type");
        //        int type = int.Parse(Console.ReadLine());
        //        Console.WriteLine("Enter the number of tickets: ");
        //        int ticketsneeded = Convert.ToInt32(Console.ReadLine());

        //        switch (type)
        //        {
        //            case 1:
        //                Console.WriteLine($"Total cost of tickets:{ticketsneeded * 3000}");
        //                break;
        //            case 2:
        //                Console.WriteLine($"Total cost of tickets:{ticketsneeded * 5000}");
        //                break;
        //            case 3:
        //                Console.WriteLine($"Total cost of tickets:{ticketsneeded * 8000}");
        //                break;

        //        }
        //    input = Console.ReadLine();

        //    } while (input != "Exit");
        //}

        #endregion

            #region Task 4: Class & Object
            ////Event @event = new Event("IPL Match",EventType.Sports, 40000, 2500, "Wankede", 3000);
           
            //Venue venue=new Venue("Wankede","Mumbai");
            //Customer customer=new Customer("Anu","anu345@gmail.com",9254638775);
            ////Booking booking = new Booking(5);
            #endregion

            #region Task 5: Inheritance and Polymorphism
            //Movie movie = new Movie("Avengers", EventType.Movie,450,125, "AMC Theatre",340,Movie.Genre.Action,"Chris Evans","Scarlett Johnsson");
            //Concert concert=new Concert("Eras Tour Concert",EventType.Concert,60000,1200,"Sofi Stadium",8000,Concert.Type.Rock,"Taylor Swift");
            //Sports sports=new Sports("IPL Match", EventType.Sports, 40000, 2500, "Wankede", 3000,"Cricket","CSK vs MI");


            //TicketBookingSystem ticketBookingSystem = new TicketBookingSystem("Football Match: Barcelona vs Real Madrid", "2024-05-20", "15:02:15", "Sport",500, "Stadium 1",25.00f);
            //while (true)
            //{

            //    Console.WriteLine("Welcome to Ticket Booking System!");
            //    Console.WriteLine("1. Book Tickets");
            //    Console.WriteLine("2. View Event Details");
            //    Console.WriteLine("3. Cancel Tickets");
            //    Console.WriteLine("4. Exit");
            //    Console.Write("Enter your choice: ");
            //    int choice = Convert.ToInt32(Console.ReadLine());

            //    switch(choice)
            //    {
            //        case 1:
            //            ticketBookingSystem.book_tickets();
            //            break;
            //        case 2:
            //            ticketBookingSystem.create_event();
            //            break;
            //        case 3:
            //            ticketBookingSystem.cancel_tickets();
            //            break;
            //        case 4:
            //            Environment.Exit(0);
            //            break;
            //         default:
            //            Console.WriteLine("Thank You for visiting!");
            //            break;

            //    }
            //}
            #endregion

          
            

          

            TicketBooking_App ticketbookingapp = new TicketBooking_App();
            ticketbookingapp.Run();
        }
    }
        
           
    
    }


    

