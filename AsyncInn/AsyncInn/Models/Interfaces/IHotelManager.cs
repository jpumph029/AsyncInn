using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    public interface IHotelManager
    {
        Task CreateHotel(Hotel hotel);

        Task<Hotel> GetHotel(int? ID);

        Task<IEnumerable<Hotel>> GetHotel();

        void UpdateHotel(Hotel hotel);

        void DeleteHotel(int ID);

    }
}
