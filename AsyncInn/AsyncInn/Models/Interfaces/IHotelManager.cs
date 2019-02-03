using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    public interface IHotelManager
    {
        //Create
        Task CreateHotel(Hotel hotel);
        //Read
        Task<Hotel> GetHotel(int? ID);
        //Read all
        Task<IEnumerable<Hotel>> GetHotel();
        //Update
        void UpdateHotel(Hotel hotel);
        //Delete
        void DeleteHotel(int ID);

    }
}
