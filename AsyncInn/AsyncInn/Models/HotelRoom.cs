using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class HotelRoom
    {
        public int HotelID{ get; set; }
        public int HotelNumber { get; set; }
        public decimal RoomID { get; set; }
        public decimal Rate { get; set; }
        public decimal PetFriendly { get; set; }

        public Hotel Hotel { get; set; }

        public Room Room { get; set; }
    }
}
