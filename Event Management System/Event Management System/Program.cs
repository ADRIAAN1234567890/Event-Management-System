using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Event_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Event_Manager em = new Event_Manager();
           
            bool running = true;

            while (running)
            {
                Console.WriteLine("Event Management System");
                Console.WriteLine("1. Create Event");
                Console.WriteLine("2. Register for Event");
                Console.WriteLine("3. Give Feedback");
                Console.WriteLine("4. Show Event Analytics");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Choose an option: ");
                
               

                switch (Console.ReadLine())
                {
                    case "1":
                        em.CreateEvent();
                        break;
                    case "2":
                        em.RegisterForEvent();
                        break;
                    case "3":
                        em.GiveFeedback();
                        break;
                    case "4":
                        em.ShowAnalytics();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}