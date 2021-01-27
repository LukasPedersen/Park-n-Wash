using System;
using System.Collections.Generic;
using System.Text;

namespace Park_n_Wash
{
    public class TicketBronze : Ticket
    {
        //Constructor
        public TicketBronze(int ticketID, DateTime timeStamp, int spotID, int pin)
        {
            TicketID = ticketID;
            TimeStamp = timeStamp;
            SpotID = spotID;
            Pin = pin;
            TicketTypeCost = 10;
        }
    }
}