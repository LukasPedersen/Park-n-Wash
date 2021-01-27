using System;
using System.Collections.Generic;
using System.Text;

namespace Park_n_Wash
{
    public class ParkingSpot
    {
        //Fields
        int id;
        string type;
        bool occupied;

        //Constructor
        public ParkingSpot(int spotID, string spotType, bool isOccupied)
        {
            id = spotID;
            type = spotType;
            occupied = isOccupied;
        }

        //Properties
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