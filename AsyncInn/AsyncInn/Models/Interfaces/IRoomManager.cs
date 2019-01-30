using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    public interface IRoomManager
    {

        Task CreateRoom(Room room);

        Task<Room> GetRoom(int? ID);

        Task<IEnumerable<Room>> GetRoom();

        void UpdateRoom(Room room);

        void DeleteRoom(int ID);

    }
}
