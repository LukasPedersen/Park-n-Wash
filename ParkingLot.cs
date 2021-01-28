using System;
using System.Collections.Generic;
using System.Text;

namespace Park_n_Wash
{
    public class ParkingLot
    {
        //Fields
        private static List<ParkingSpot> allSpots;

        //Constructor
        public ParkingLot()
        {
            allSpots = new List<ParkingSpot>();
        }

        public static List<ParkingSpot> ShowAvailableSpots()
        {
            List<ParkingSpot> listOfAvailavleSpots = new List<ParkingSpot>();
            foreach (ParkingSpot parkingSpot in allSpots)
            {
                if (parkingSpot.Occupied == false)
                {
                    listOfAvailavleSpots.Add(parkingSpot);
                }

            }
            return listOfAvailavleSpots;
        }
        public static List<ParkingSpot> ShowAllSpots()
        {
            return allSpots;
        }
        public static void SaveParkingSpot(List<ParkingSpot> ps)
        {
            allSpots = ps;
        }
        
        //Properties
        public List<ParkingSpot> AllSpots
        {
            get => allSpots;
            set
            {
                allSpots = value;
            }
        }
    }
}