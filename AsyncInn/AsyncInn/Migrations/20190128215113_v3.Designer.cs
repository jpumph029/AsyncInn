﻿// <auto-generated />
using AsyncInn.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AsyncInn.Migrations
{
    [DbContext(typeof(AsyncInnDbContext))]
    [Migration("20190128215113_v3")]
    partial class v3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AsyncInn.Models.Amenities", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Amenities");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Coffee"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Phone"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Shower"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Mini Bar"
                        },
                        new
                        {
                            ID = 5,
                            Name = "Hot Tub"
                        });
                });

            modelBuilder.Entity("AsyncInn.Models.Hotel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Phone");

                    b.HasKey("ID");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Address = "Seattle",
                            Name = "Seattle",
                            Phone = "1234567890"
                        },
                        new
                        {
                            ID = 2,
                            Address = "123 Portland St",
                            Name = "Portland",
                            Phone = "5415416667"
                        },
                        new
                        {
                            ID = 3,
                            Address = "234 Springfield St",
                            Name = "Springfield",
                            Phone = "0987654321"
                        },
                        new
                        {
                            ID = 4,
                            Address = "345 Eugene St",
                            Name = "Eugene",
                            Phone = "2347568888"
                        },
                        new
                        {
                            ID = 5,
                            Address = "1234 Astoria wy",
                            Name = "Astoria",
                            Phone = "2223334444"
                        });
                });

            modelBuilder.Entity("AsyncInn.Models.HotelRoom", b =>
                {
                    b.Property<int>("HotelID");

                    b.Property<int>("RoomNumber");

                    b.Property<decimal>("PetFriendly");

                    b.Property<decimal>("Rate");

                    b.Property<decimal>("RoomID");

                    b.Property<int>("RoomID1");

                    b.HasKey("HotelID", "RoomNumber");

                    b.HasIndex("RoomID1");

                    b.ToTable("HotelRooms");
                });

            modelBuilder.Entity("AsyncInn.Models.Room", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Layout");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Layout = 0,
                            Name = "StudioFirstFloor"
                        },
                        new
                        {
                            ID = 2,
                            Layout = 0,
                            Name = "StudioSecondFloor"
                        },
                        new
                        {
                            ID = 3,
                            Layout = 1,
                            Name = "OneBedFirstFloor"
                        },
                        new
                        {
                            ID = 4,
                            Layout = 1,
                            Name = "OneBedSecondFloor"
                        },
                        new
                        {
                            ID = 5,
                            Layout = 2,
                            Name = "TwoBedFirstFloor"
                        },
                        new
                        {
                            ID = 6,
                            Layout = 2,
                            Name = "TwoBedSecondFloor"
                        });
                });

            modelBuilder.Entity("AsyncInn.Models.RoomAmenities", b =>
                {
                    b.Property<int>("AmenitiesID");

                    b.Property<int>("RoomID");

                    b.HasKey("AmenitiesID", "RoomID");

                    b.HasIndex("RoomID");

                    b.ToTable("RoomAmenities");
                });

            modelBuilder.Entity("AsyncInn.Models.HotelRoom", b =>
                {
                    b.HasOne("AsyncInn.Models.Hotel", "Hotel")
                        .WithMany("HotelRoom")
                        .HasForeignKey("HotelID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AsyncInn.Models.Room", "Room")
                        .WithMany("HotelRoom")
                        .HasForeignKey("RoomID1")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AsyncInn.Models.RoomAmenities", b =>
                {
                    b.HasOne("AsyncInn.Models.Amenities", "Amenities")
                        .WithMany("RoomAmenities")
                        .HasForeignKey("AmenitiesID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AsyncInn.Models.Room", "Room")
                        .WithMany("RoomAmenities")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
