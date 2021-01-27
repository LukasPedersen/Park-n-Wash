using System;
using System.Collections.Generic;

namespace Park_n_Wash
{
    class Program
    {
        static void Main()
        {
            InitializeComponents();
        }
        //Initializing of components
        private static void InitializeComponents()
        {
            ParkingLot pl = new ParkingLot();
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            //Make 50 personal vehicle parking spots
            int idCount = 1;
            for (int i = 0; i < 50; i++)
            {
                pl.AllSpots.Add(new ParkingSpot(idCount, "Personal vehicle", false));
                idCount++;
            }
            //Make 10 trailer parking spots
            for (int i = 0; i < 10; i++)
            {
                pl.AllSpots.Add(new ParkingSpot(idCount, "Trailer", false));
                idCount++;
            }
            //Make 12 truck parking spots
            for (int i = 0; i < 12; i++)
            {
                pl.AllSpots.Add(new ParkingSpot(idCount, "Truck", false));
                idCount++;
            }
            //Make 5 handicap friendly parking spots
            for (int i = 0; i < 5; i++)
            {
                pl.AllSpots.Add(new ParkingSpot(idCount, "Handicap friendly", false));
                idCount++;
            }
            ParkingLot.SaveParkingSpot(pl.AllSpots);
            Menu();
        }

        //User menu
        public static void Menu()
        {
            Program pg = new Program();
            pg.WriteToConsole($"Hello and wellcome to Park'n'Wash\nAll spots:\n", 25);
            foreach (ParkingSpot parkingspot in ParkingLot.ShowAllSpots())
            {
                Console.WriteLine($"Parking spot number: {parkingspot.ID} Type: {parkingspot.Type} Occupied?: {parkingspot.Occupied}");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Writes each char from <paramref name="text"></paramref> to console with a thread.sleep(<paramref name="speed"></paramref>) between each char
        /// </summary>
        /// <param name="text"></param>
        /// <param name="speed"></param>
        public void WriteToConsole(string text, int speed)
        {
            foreach (char letter in text)
            {
                Console.Write(letter);
                System.Threading.Thread.Sleep(speed);
            }
        }
    }
}
