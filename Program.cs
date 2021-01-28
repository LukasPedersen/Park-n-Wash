﻿using System;
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
            Program pg = new Program();
            int countPersonalVehicle = 0;
            int countTrailer = 0;
            int countTruck = 0;
            int countHandicapFriendly = 0;
            ConsoleHandler.WriteToConsole($"Hello and wellcome to Park'n'Wash\n", 25);
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
            ConsoleHandler.WriteToConsole($"\nAvailable parking spots:\n[{countPersonalVehicle.ToString("000")}] Personal vehicle spots\n[{countTrailer.ToString("000")}] Trailer spots\n[{countTruck.ToString("000")}] Truck Spots\n[{countHandicapFriendly.ToString("000")}] Handicap friendly spots" ,25);
            Console.ReadKey();
        }
    }
}
