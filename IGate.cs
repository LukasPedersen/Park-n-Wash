using System;
using System.Collections.Generic;
using System.Text;

namespace Park_n_Wash
{
    public interface IGate
    {
        void CheckIn(UInt16 ticketType, int parkingSpotID);
        string CheckOut(int pin);
    }
}