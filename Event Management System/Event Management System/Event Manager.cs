using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Event_Management_System
{
    class Event_Manager
    {
        private List<Event> events = new List<Event>();

        public void CreateEvent()
        {
            try
            {
                Console.Write("Enter event name: ");
                string name = Console.ReadLine();
                Console.Write("What time is your event dedicated for (yyyy-mm-dd): ");
                string date = Console.ReadLine();
                Console.Write("Enter number of tickets: ");
                int ticketCount = int.Parse(Console.ReadLine());

                events.Add(new Event { Name = name, Date = date, TicketCount = ticketCount });
                Console.WriteLine("Event created successfully.");
            }
            catch (Exception EX)
            {
                Console.WriteLine("Event already exists: " + EX.Message);
            }
        }

        public void RegisterForEvent()
        {
            try
            {
                Console.Write("Enter event name to register: ");
                string eventName = Console.ReadLine();
                Event evt = events.Find(e => e.Name.Equals(eventName, StringComparison.OrdinalIgnoreCase));

                if (evt != null && evt.Registrations.Count < evt.TicketCount)
                {
                    Console.Write("Enter your name: ");
                    string userName = Console.ReadLine();
                    evt.Registrations.Add(userName);
                    Console.WriteLine("Registered successfully.");
                }
                else
                {
                    Console.WriteLine("Event not found or tickets sold out.");
                }
            }
            catch (Exception EX)
            {
                Console.WriteLine("Error: " + EX.Message);
            }
        }
            
        
        public void GiveFeedback()
        {
                Console.Write("Enter event name to give feedback: ");
                string eventName = Console.ReadLine();
                Event evt = events.Find(e => e.Name.Equals(eventName, StringComparison.OrdinalIgnoreCase));

                if (evt != null)
                {
                    Console.Write("Enter your feedback: ");
                    string feedback = Console.ReadLine();
                    evt.Feedbacks.Add(feedback);
                    Console.WriteLine("Feedback submitted successfully.");
                }
                else
                {
                    Console.WriteLine("Event not found.");
                }
        }

        public void ShowAnalytics()
        {
            try
            {
                foreach (var evt in events)
                {
                    Console.WriteLine("Event: " + evt.Name+"\n"+"Date: " + evt.Date+ "\n"+"Registered: " + evt.Registrations.Count);
                }
            }
            catch (Exception EX)
            {
                Console.WriteLine("Error: " + EX.Message);
            }
        }
    }
}
    

