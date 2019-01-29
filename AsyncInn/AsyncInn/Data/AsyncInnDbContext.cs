using AsyncInn.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Data
{
    public class AsyncInnDbContext : DbContext
    {
        public AsyncInnDbContext(DbContextOptions<AsyncInnDbContext>
            options): base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Add our composite key associations
            modelBuilder.Entity<HotelRoom>().HasKey(ce => new { ce.HotelID, ce.RoomNumber });
            modelBuilder.Entity<RoomAmenities>().HasKey(ce => new { ce.AmenitiesID, ce.RoomID });

            modelBuilder.Entity<Hotel>().HasData(
            new Hotel
            {
                ID = 1,
                Name = "Seattle",
                Address = "Seattle",
                Phone = "1234567890"
            },
            new Hotel
            { 
                ID = 2,
                Name = "Portland",
                Address = "123 Portland St",
                Phone = "5415416667"
            },
            new Hotel
            {
                ID = 3,
                Name = "Springfield",
                Address = "234 Springfield St",
                Phone = "0987654321"
            },
            new Hotel
            {
                ID = 4,
                Name = "Eugene",
                Address = "345 Eugene St",
                Phone = "2347568888"
            },
            new Hotel
            {
                ID = 5,
                Name = "Astoria",
                Address = "1234 Astoria wy",
                Phone = "2223334444"
            }
            );

            modelBuilder.Entity<Room>().HasData(
            new Room
            {
                ID = 1,
                Name = "StudioFirstFloor",
                Layout = 0,
            },
            new Room
            {
                ID = 2,
                Name = "StudioSecondFloor",
                Layout = 0
            },
            new Room
            {
                ID = 3,
                Name = "OneBedFirstFloor",
                Layout = 1,
            },
            new Room
            {
                ID = 4,
                Name = "OneBedSecondFloor",
                Layout = 1,
            },
            new Room
            {
                ID = 5,
                Name = "TwoBedFirstFloor",
                Layout = 2,
            },
            new Room
            {
                ID = 6,
                Name = "TwoBedSecondFloor",
                Layout = 2,
            }
            );
            modelBuilder.Entity<Amenities>().HasData(
                new Amenities
                {
                    ID = 1,
                    Name = "Coffee",
                },
                new Amenities
                {
                    ID = 2,
                    Name = "Phone",
                },
                new Amenities
                {
                    ID = 3,
                    Name = "Shower",
                },
                new Amenities
                {
                    ID = 4,
                    Name = "Mini Bar",
                },
                new Amenities
                {
                    ID = 5,
                    Name = "Hot Tub",
                }

                );






        }
        //tables
        public DbSet<Amenities> Amenities { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelRoom> HotelRooms { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomAmenities> RoomAmenities { get; set; }


    }
}
