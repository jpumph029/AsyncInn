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

        public async Task<IActionResult> Index()
        {
            return View(await _rooms.GetRoom());
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return View();

            }

            return View(await _rooms.GetRoom(id));
        }
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {

            _rooms.DeleteRoom(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NoContent();
            }

            return View(await _rooms.GetRoom(id));
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return View();
            }
            return View(await _rooms.GetRoom(id));
        }
        [HttpPost]
        [ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmEdit(Room room)
        {
            _rooms.UpdateRoom(room);
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }
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
