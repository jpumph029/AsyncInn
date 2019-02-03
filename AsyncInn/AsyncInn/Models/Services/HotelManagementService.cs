using AsyncInn.Data;
using AsyncInn.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Services
{
    public class HotelManagementService : IHotelManager
    {
        private AsyncInnDbContext _context { get; }

        public HotelManagementService(AsyncInnDbContext context)
        {
            _context = context;
        }
        //Create
        public async Task CreateHotel(Hotel hotel)
        {
            _context.Hotels.Add(hotel);
            await _context.SaveChangesAsync();
        }
        //Read All
        public async Task<IEnumerable<Hotel>> GetHotel()
        {
            return await _context.Hotels.ToListAsync();
        }
        //Read
        public async Task<Hotel> GetHotel(int? id)
        {
            return await _context.Hotels.FirstOrDefaultAsync(hotel => hotel.ID == id);
        }
        //Update
        public void UpdateHotel(Hotel hotel)
        {
            _context.Hotels.Update(hotel);
            _context.SaveChanges();
        }
        //Delete
        public void DeleteHotel(int id)
        {
            Hotel hotel = _context.Hotels.FirstOrDefault(a => a.ID == id);
            _context.Hotels.Remove(hotel);
            _context.SaveChanges();
        }
    }
}
