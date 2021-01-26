using System;
using System.Collections.Generic;
using System.Text;

namespace Park_n_Wash
{
    public class Ticket
    {
        int id;
        DateTime date;

        public Ticket(int ticketID, DateTime timeStamp)
        {
            id = ticketID;
            date = timeStamp;
        }
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
    }
}