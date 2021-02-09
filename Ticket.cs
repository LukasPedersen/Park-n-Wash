using System;
using System.Collections.Generic;
using System.Text;

namespace Park_n_Wash
{
    public class Ticket
    {
        //Fields
        private int id;
        private DateTime date;
        private int spotID;
        private int pin;
        private int ticketTypeCost;

        public virtual void ConsoleColor()
        {

        }
        //Properties
        public DateTime TimeStamp
        {
            get => date;
            set
            {
                date = value;
            }
        }

        public int TicketID
        {
            get => id;
            set
            {
                id = value;
            }
        }

        public int SpotID
        {
            get => spotID;
            set
            {
                spotID = value;
            }
        }

        public int Pin
        {
            get => pin;
            set
            {
                pin = value;
            }
        }
        public int TicketTypeCost
        {
            get => ticketTypeCost;
            set
            {
                ticketTypeCost = value;
            }
        }
    }
}