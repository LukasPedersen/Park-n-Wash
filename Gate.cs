using System;
using Park_n_Wash.Common;
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

        public string CheckOut(int pin)
        {
            string timeParked = "";
            int spotID = 0;
            double pay;
            foreach (Ticket ticket in tickets)
            {
                if (ticket.Pin == pin)
                {
                    spotID = ticket.SpotID;
                    TimeSpan parkingDuration = DateTime.Now - ticket.TimeStamp;
                    pay = (ticket.TicketTypeCost / 60) * parkingDuration.TotalMinutes;
                    timeParked = $"You have parked for:\n{parkingDuration.Days} Days\n{parkingDuration.Hours} Hours\n{parkingDuration.Minutes} Minutes\n\nSo you need to pay: {pay.ToString("0.00")} Kr.\nPress any key to pay...";
                }
            }
            foreach (ParkingSpot parkingSpot in ParkingLot.ShowAllSpots())
            {
                if (parkingSpot.ID == spotID)
                {
                    parkingSpot.Occupied = false;
                }
            }
            
            return timeParked;
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
                    Ticket g = new TicketGold(GenerateTicketID(), DateTime.Now, parkingSpotID, GeneratePin());
                    ConsoleHandler.WriteToConsole($"Ticket infomation:\nTicket type: Gold\nTicket ID: {g.TicketID}\nParking spot ID: {g.SpotID}\nTicket pin code: {g.Pin} Remember this!\nParking cost per hour: {g.TicketTypeCost}kr/h\nTicket created: {g.TimeStamp}\n\nPress any key to continue...", 20);
                    Console.ReadKey();
                    tickets.Add(g);
                    break;
                case 2:
                    Ticket s = new TicketSilver(GenerateTicketID(), DateTime.Now, parkingSpotID, GeneratePin());
                    ConsoleHandler.WriteToConsole($"Ticket infomation:\nTicket type: Silver\nTicket ID: {s.TicketID}\nParking spot ID: {s.SpotID}\nTicket pin code: {s.Pin} Remember this!\nParking cost per hour: {s.TicketTypeCost}kr/h\nTicket created: {s.TimeStamp}\n\nPress any key to continue...", 20);
                    Console.ReadKey();
                    tickets.Add(s);
                    break;
                case 3:
                    Ticket b = new TicketBronze(GenerateTicketID(), DateTime.Now, parkingSpotID, GeneratePin());
                    ConsoleHandler.WriteToConsole($"Ticket infomation:\nTicket type: Bronze\nTicket ID: {b.TicketID}\nParking spot ID: {b.SpotID}\nTicket pin code: {b.Pin} Remember this!\nParking cost per hour: {b.TicketTypeCost}kr/h\nTicket created: {b.TimeStamp}\n\nPress any key to continue...", 20);
                    Console.ReadKey();
                    tickets.Add(b);
                    break;
            }
        }

        private void MakeTicketInvalid()
        {
            /// TODO: "Delete" ticket
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