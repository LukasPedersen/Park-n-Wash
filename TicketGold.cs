using System;
using System.Collections.Generic;
using System.Text;

namespace Park_n_Wash
{
    public class TicketGold : Ticket
    {
        //Constructor
        public TicketGold(int ticketID, DateTime timeStamp, int spotID, int pin)
        {
            TicketID = ticketID;
            TimeStamp = timeStamp;
            SpotID = spotID;
            Pin = pin;
            TicketTypeCost = 500;
        }
        //Change text color to "Gold"
        public override void ConsoleColor()
        {
            Console.ForegroundColor = System.ConsoleColor.DarkYellow;
        }
    }
}