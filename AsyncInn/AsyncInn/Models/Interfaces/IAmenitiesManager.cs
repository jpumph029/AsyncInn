using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    public interface IAmenitiesManager
    {
        //Create
        Task CreateAmenities(Amenities amenities);
        //Read
        Task<Amenities> GetAmenities(int? id);
        //Read All
        Task<IEnumerable<Amenities>> GetAmenities();
        //Update
        void UpdateAmenities(Amenities amenities);
        //Delete
        void DeleteAmenities(int id);


    }
}
