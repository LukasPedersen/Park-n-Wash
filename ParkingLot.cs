using System;
using System.Collections.Generic;
using System.Text;

namespace Park_n_Wash
{
    public class ParkingLot
    {
        private List<ParkingSpot> allSpots;

        public ParkingLot()
        {
            allSpots = new List<ParkingSpot>();
        }
        public void ShowAvailableSpots()
        {
            throw new System.NotImplementedException();
        }

        public List<ParkingSpot> ShowAllSpots()
        {
            return allSpots;
        }
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