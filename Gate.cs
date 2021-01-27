using System;
using System.Collections.Generic;
using System.Text;

namespace Park_n_Wash
{
    public class GateRepository : IGate
    {
        private List<Ticket> tickets = new List<Ticket>();
        public void CheckIn()
        {

        }

        public void CheckOut()
        {

        }
        public void CreateTicket(UInt16 ticketType, int parkingSpotID)
        {
            
            switch (ticketType)
            {
                case 1:
                    tickets.Add(new TicketGold(GenerateTicketID(), DateTime.Today, parkingSpotID, GeneratePin()));
                    break;
                case 2:
                    tickets.Add(new TicketSilver(GenerateTicketID(), DateTime.Today, parkingSpotID, GeneratePin()));
                    break;
                case 3:
                    tickets.Add(new TicketBronze(GenerateTicketID(), DateTime.Today, parkingSpotID, GeneratePin()));
                    break;
                default:
                    break;
            }
        }
        public void DeleteTicket()
        {

        }
        private static int GenerateTicketID()
        {
            Random random = new Random();
            string formatNumber = random.Next(0, 9999).ToString("D4");
            int newTicketID;
            try
            {
                newTicketID = Convert.ToInt16(formatNumber);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            return newTicketID;
        }
        private static int GeneratePin()
        {
            Random random = new Random();
            string formatNumber = random.Next(0, 9999).ToString("D4");
            int newPin;
            try
            {
                newPin = Convert.ToInt16(formatNumber);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            return newPin;
        }
    }
}