using AsyncInn.Data;
using AsyncInn.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Services
{
    public class AmenitiesManagementService : IAmenitiesManager
    {
        private AsyncInnDbContext _context { get; }

        public AmenitiesManagementService(AsyncInnDbContext context)
        {
            _context = context;
        }
        //Create
        public async Task CreateAmenities(Amenities amenities)
        {
            _context.Amenities.Add(amenities);
            await _context.SaveChangesAsync();
        }
        //Read All
        public async Task<IEnumerable<Amenities>> GetAmenities()
        {
            return await _context.Amenities.ToListAsync();
        }
        //Read
        public async Task<Amenities> GetAmenities(int? id)
        {
            return await _context.Amenities.FirstOrDefaultAsync(amenitites => amenitites.ID == id);
        }
        //Update
        public void UpdateAmenities(Amenities amenities)
        {
            _context.Amenities.Update(amenities);
            _context.SaveChanges();
        }
        //Delete
        public void DeleteAmenities(int id)
        {
            var amenities =  _context.Amenities.FirstOrDefault(a => a.ID == id);
            _context.Amenities.Remove(amenities);
            _context.SaveChanges();
        }
    }
}
