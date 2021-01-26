using System;
using System.Collections.Generic;
using System.Text;

namespace Park_n_Wash
{
    public class Ticket
    {
        int ticketID;
        DateTime date;

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
            get => ticketID;
            set
            {
                ticketID = value;
            }
        }
    }
}