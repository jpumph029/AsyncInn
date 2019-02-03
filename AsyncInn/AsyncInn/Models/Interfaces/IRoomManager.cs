using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    public interface IRoomManager
    {
        //Create
        Task CreateRoom(Room room);
        //Read
        Task<Room> GetRoom(int? ID);
        //Read All
        Task<IEnumerable<Room>> GetRoom();
        //Update
        void UpdateRoom(Room room);
        //Delete
        void DeleteRoom(int ID);

    }
}
