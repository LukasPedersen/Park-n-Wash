using System;
using System.Collections.Generic;
using System.Text;

namespace Park_n_Wash
{
    public class ParkingSpot
    {
        int id;
        string type;
        bool occupied;

        public ParkingSpot()
        {

        }
        public ParkingSpot(int spotID, string spotType, bool isOccupied)
        {
            id = spotID;
            type = spotType;
            occupied = isOccupied;
        }

        public int ID
        {
            get => id;
            set
            {
                id = value;
            }
        }

        public string Type
        {
            get => type;
            set
            {
                type = value;
            }
        }

        public bool Occupied
        {
            get => occupied;
            set
            {
                occupied = value;
            }
        }
    }
}