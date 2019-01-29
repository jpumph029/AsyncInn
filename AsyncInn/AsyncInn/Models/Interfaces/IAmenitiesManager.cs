using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    public interface IAmenitiesManager
    {
        Task CreateAmenities(Amenities amenities);

        Task<Amenities> GetAmenities(int? id);

        Task<IEnumerable<Amenities>> GetAmenities();

        void UpdateAmenities(Amenities amenities);

        void DeleteAmenities(int id);


    }
}
