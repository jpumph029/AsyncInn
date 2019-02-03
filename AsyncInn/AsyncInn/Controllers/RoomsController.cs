using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AsyncInn.Data;
using AsyncInn.Models;
using AsyncInn.Models.Interfaces;

namespace AsyncInn.Controllers
{
    public class RoomsController : Controller
    {
        private IRoomManager _rooms { get; }

        public RoomsController(IRoomManager db)
        {
            _rooms = db;
        }
        //GET: Rooms/Index
        public async Task<IActionResult> Index()
        {
            return View(await _rooms.GetRoom());
        }
        //GET:Rooms/Delete/ID
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return View();

            }

            return View(await _rooms.GetRoom(id));
        }
        //POST: Rooms/Delete/ID
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {

            _rooms.DeleteRoom(id);
            return RedirectToAction("Index");
        }
        //GET: Rooms/Details/ID
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NoContent();
            }

            return View(await _rooms.GetRoom(id));
        }
        //GET: Rooms/Edit/ID
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return View();
            }
            return View(await _rooms.GetRoom(id));
        }
        //POST: ROoms/Edit/ID
        [HttpPost]
        [ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmEdit(Room room)
        {
            _rooms.UpdateRoom(room);
            return RedirectToAction("Index");
        }
        //GET: Rooms/Create/
        public IActionResult Create()
        {
            return View();
        }
        //POST: Rooms/Create/room
        [HttpPost]
        [ActionName("Create")]
        public async Task<IActionResult> ConfirmCreate(Room room)
        {
            if (ModelState.IsValid)
            {
                await _rooms.CreateRoom(room);
                return RedirectToAction("Index");
            }
            return View(room);
        }
    }
}
