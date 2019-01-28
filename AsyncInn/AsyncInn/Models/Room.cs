using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class Room
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Layout { get; set; }
        
        public ICollection<HotelRoom> HotelRoom { get; set; }
    
        public ICollection<RoomAmenities> RoomAmenities { get; set; }
    }

    public enum Layout
    {
        Studio,
        OneBedroom,
        TwoBedroom
    }
}
