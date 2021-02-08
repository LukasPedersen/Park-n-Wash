using System;
using Park_n_Wash.Common;
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
            GateRepository gate = new GateRepository();
            do
            {
                int countPersonalVehicle = 0;
                int countTrailer = 0;
                int countTruck = 0;
                int countHandicapFriendly = 0;
                bool loop = true;
                Console.Clear();
                ConsoleHandler.WriteToConsole($"Hello and wellcome to Park'n'Wash\n", 20);
                do
                {
                    ConsoleHandler.WriteToConsole($"1: Check in\n2: Check out\n", 20);
                    string key = Console.ReadKey().KeyChar.ToString();
                    Console.Clear();
                    switch (key)
                    {
                        case "1":
                            loop = false;
                            break;
                        case "2":
                            ConsoleHandler.WriteToConsole($"Input pin code from your ticket:\n", 20);
                            int pin = Convert.ToInt32(Console.ReadLine());
                            ConsoleHandler.WriteToConsole(gate.CheckOut(pin), 20);
                            Console.ReadKey();
                            Console.Clear();
                            ConsoleHandler.WriteToConsole("Please come again...", 20);
                            Console.Clear();
                            break;
                    }

                } while (loop);
                loop = true;
                //Finds all available parking spots and counts how many there are
                foreach (ParkingSpot parkingspot in ParkingLot.ShowAvailableSpots())
                {
                    switch (parkingspot.Type)
                    {
                        case "Personal vehicle":
                            countPersonalVehicle++;
                            break;
                        case "Trailer":
                            countTrailer++;
                            break;
                        case "Truck":
                            countTruck++;
                            break;
                        case "Handicap friendly":
                            countHandicapFriendly++;
                            break;
                    }
                }
                ConsoleHandler.WriteToConsole($"Available parking spots:\n[{countPersonalVehicle.ToString("000")}] Personal vehicle spots\n[{countTrailer.ToString("000")}] Trailer spots\n[{countTruck.ToString("000")}] Truck Spots\n[{countHandicapFriendly.ToString("000")}] Handicap friendly spots\n", 20);
                ConsoleHandler.WriteToConsole("\nSelect your parking spot type:\n1: Personal vehicle spot\n2: Trailer spot\n3: Truck Spot\n4: Handicap friendly spot\n", 20);
                string spotType = "";
                do
                {
                    string key = Console.ReadKey().KeyChar.ToString();
                    switch (key)
                    {
                        case "1":
                            spotType = "Personal vehicle";
                            loop = false;
                            break;
                        case "2":
                            spotType = "Trailer";
                            loop = false;
                            break;
                        case "3":
                            spotType = "Truck";
                            loop = false;
                            break;
                        case "4":
                            spotType = "Handicap friendly";
                            loop = false;
                            break;
                    }
                } while (loop);
                loop = true;

                //Finds first available parking spot ID with the selected type
                int spotID = 0;
                foreach (ParkingSpot parkingSpot in ParkingLot.ShowAvailableSpots())
                {
                    if (parkingSpot.Type == spotType && parkingSpot.Occupied == false)
                    {
                        spotID = parkingSpot.ID;
                        parkingSpot.Occupied = true;
                        break;
                    }
                }
                Console.Clear();
                ConsoleHandler.WriteToConsole("Select ticket type\n", 20);
                ConsoleHandler.WriteToConsole("\nDifference between ticket types\nGold ticket 500kr kr/t includes: Parking, car wash and better security\nSilver ticket 350kr kr/t includes: Parking and car wash\nBronze ticket 200kr kr/t includes: Parking\n", 20);
                ConsoleHandler.WriteToConsole("1: Gold\n2: Silver\n3: Bronze\nX: Exit\n", 20);
                UInt16 ticketTypeInt = 0;
                string ticketTypeString = "";
                do
                {
                    string key = Console.ReadKey().KeyChar.ToString();
                    switch (key)
                    {
                        case "1":
                            ticketTypeInt = 1;
                            ticketTypeString = "Gold";
                            loop = false;
                            break;
                        case "2":
                            ticketTypeInt = 2;
                            ticketTypeString = "Silver";
                            loop = false;
                            break;
                        case "3":
                            ticketTypeInt = 3;
                            ticketTypeString = "Bronze";
                            loop = false;
                            break;
                        case "x":
                            loop = false;
                            Menu();
                            break;
                    }
                } while (loop);
                loop = true;
                Console.Clear();

                ConsoleHandler.WriteToConsole($"Is your ticket infomation correct Y/N?\nParking spot type: {spotType}\nTicket type: {ticketTypeString}\n", 20);
                do
                {
                    string key = Console.ReadKey().KeyChar.ToString();
                    switch (key)
                    {
                        case "y":
                            Console.Clear();
                            gate.CheckIn(ticketTypeInt, spotID);
                            loop = false;
                            break;
                        case "n":
                            Console.Clear();
                            ConsoleHandler.WriteToConsole("Please try again", 20);
                            ConsoleHandler.WriteToConsole("...", 500);
                            break;
                    }
                } while (loop);
                loop = true;
                Console.Clear();
                ConsoleHandler.WriteToConsole("Printing ticket", 20);
                ConsoleHandler.WriteToConsole(".....", 1000);
                Console.Clear();
                ConsoleHandler.WriteToConsole("Have a nice day", 20);
                ConsoleHandler.WriteToConsole("...", 500);
            } while (true);
            
        }
    }
}
