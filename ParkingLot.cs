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
        
        public void ShowAvailableSpots()
        {
            throw new System.NotImplementedException();
        }
        public static void SaveParkingSpot(List<ParkingSpot> ps)
        {
            allSpots = ps;
        }
        public static List<ParkingSpot> ShowAllSpots()
        {
            return allSpots;
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