﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class HotelRoom
    {
        [Required]
        public int HotelID{ get; set; }
        [Required]
        public int RoomNumber { get; set; }
        [Required]
        public decimal RoomID { get; set; }
        [Required]
        public decimal Rate { get; set; }
        [Required]
        public decimal PetFriendly { get; set; }
        [Required]
        public Hotel Hotel { get; set; }
        [Required]
        public Room Room { get; set; }
    }
}
