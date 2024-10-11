using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Event_Management_System
{
    class Event
    {
        private string name;
        private string date;
        private int ticketCount;
        private List<string> registrations;
        private List<string> feedbacks;

        public Event()
        {
            registrations = new List<string>();
            feedbacks = new List<string>();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value ; }
        }

        public int TicketCount
        {
            get { return ticketCount; }
            set { ticketCount = value; }
        }

        public List<string> Registrations
        {
            get { return registrations; }
        }

        public List<string> Feedbacks
        {
            get { return feedbacks; }
        }
    }
}
