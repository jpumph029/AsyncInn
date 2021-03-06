﻿using AsyncInn.Data;
using AsyncInn.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Services
{
    public class RoomManagementService : IRoomManager
    {
        private AsyncInnDbContext _context { get; }

        public RoomManagementService(AsyncInnDbContext context)
        {
            _context = context;
        }
        //Create
        public async Task CreateRoom(Room room)
        {
            _context.Rooms.Add(room);
            await _context.SaveChangesAsync();
        }
        //Read All
        public async Task<IEnumerable<Room>> GetRoom()
        {
            return await _context.Rooms.ToListAsync();
        }
        //Read
        public async Task<Room> GetRoom(int? id)
        {
            return await _context.Rooms.FirstOrDefaultAsync(hotel => hotel.ID == id);
        }
        //Update    
        public void UpdateRoom(Room room)
        {
            _context.Rooms.Update(room);
            _context.SaveChanges();
        }
        //Delete
        public void DeleteRoom(int id)
        {
            Room room = _context.Rooms.FirstOrDefault(a => a.ID == id);
            _context.Rooms.Remove(room);
            _context.SaveChanges();
        }

    }
}
