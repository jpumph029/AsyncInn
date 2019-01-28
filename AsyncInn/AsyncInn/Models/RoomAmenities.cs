using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class RoomAmenities
    {
        [Required]
        public int AmenitiesID { get; set; }
        [Required]
        public int RoomID { get; set; }
        [Required]
        public Amenities Amenities { get; set; }
        [Required]
        public Room Room { get; set; }
    }
}
