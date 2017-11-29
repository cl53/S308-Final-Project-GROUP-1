using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group01
{
   public class Room
    {
        
        public string RoomType { get; set; }
        public double RoomPrice { get; set; }
        public byte NumberOfBeds { get; set; }
        public bool TVAccess { get; set; }
        public bool WiFiAccess { get; set; }
        public bool BreakfastIncluded { get; set; }

        public Room()
        {
            RoomType = "One King";
            RoomPrice = 0;
            NumberOfBeds = 0;
            TVAccess = false;
            WiFiAccess = false;
            BreakfastIncluded = false;
        }
        public Room(string Roomtype, double Roomprice, byte Numberofbeds, bool tvaccess, bool wifiaccess, bool breakfastincluded)
        {
            RoomType = Roomtype;
            RoomPrice = Roomprice;
            NumberOfBeds = Numberofbeds;
            TVAccess = tvaccess;
            WiFiAccess = wifiaccess;
            BreakfastIncluded = breakfastincluded;
        }
       
    }

    
    





}
