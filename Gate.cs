using System;
using System.Collections.Generic;
using System.Text;

namespace Park_n_Wash
{
    public class GateRepository : IGate
    {
        private List<Ticket> tickets;

        public GateRepository()
        {
            tickets = new List<Ticket>();
        }
        public void CheckIn(UInt16 ticketType, int parkingSpotID)
        {
            CreateTicket(ticketType, parkingSpotID);
        }

        public void CheckOut(UInt16 ticketType, int parkingSpotID)
        {

        }
        /// <summary>
        /// Create a ticket with a random TicketID and random Pin a TimeStamp and a parking spot id
        /// </summary>
        /// <param name="ticketType"></param>
        /// <param name="parkingSpotID"></param>
        private void CreateTicket(UInt16 ticketType, int parkingSpotID)
        {
            
            switch (ticketType)
            {
                case 1:
                    tickets.Add(new TicketGold(GenerateTicketID(), DateTime.Now, parkingSpotID, GeneratePin()));
                    break;
                case 2:
                    tickets.Add(new TicketSilver(GenerateTicketID(), DateTime.Now, parkingSpotID, GeneratePin()));
                    break;
                case 3:
                    tickets.Add(new TicketBronze(GenerateTicketID(), DateTime.Now, parkingSpotID, GeneratePin()));
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private void DeleteTicket()
        {

        }

        /// <summary>
        /// Generate a new TicketID
        /// </summary>
        /// <returns>Said TicketID</returns>
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
            System.Threading.Thread.Sleep(100);
            return newTicketID;
        }
        /// <summary>
        /// Generate a new pin code
        /// </summary>
        /// <returns>Said pin code</returns>
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
            System.Threading.Thread.Sleep(100);
            return newPin;
        }
    }
}