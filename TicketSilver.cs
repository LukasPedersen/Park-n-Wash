﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Park_n_Wash
{
    public class TicketSilver : Ticket
    {
        //Constructor
        public TicketSilver(int ticketID, DateTime timeStamp, int spotID, int pin)
        {
            TicketID = ticketID;
            TimeStamp = timeStamp;
            SpotID = spotID;
            Pin = pin;
            TicketTypeCost = 350;
        }
        //Change text color to "Silver"
        public override void ConsoleColor()
        {
            Console.ForegroundColor = System.ConsoleColor.Gray;
        }
    }
}