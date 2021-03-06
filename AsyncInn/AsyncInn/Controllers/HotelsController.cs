﻿using System;
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
    public class HotelsController : Controller
    {
        private IHotelManager _hotels { get; }

        public HotelsController(IHotelManager db)
        {
            _hotels = db;
        }

        //GET: Hotels/Index
        public async Task<IActionResult> Index()
        {
            return View(await _hotels.GetHotel());
        }

        //GET: Hotels/Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return View();

            }

            return View(await _hotels.GetHotel(id));
        }
        //POST: Hotels/Delete/ID
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {

            _hotels.DeleteHotel(id);
            return RedirectToAction("Index");
        }
        //GET: Hotels/Details/ID
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NoContent();
            }

            return View(await _hotels.GetHotel(id));
        }
        //GET: Hotels/Edit/ID
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return View();
            }
            return View(await _hotels.GetHotel(id));
        }
        //POST: Hotels/Edit/Hotel
        [HttpPost]
        [ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmEdit(Hotel hotel)
        {
            _hotels.UpdateHotel(hotel);
            return RedirectToAction("Index");
        }
        //GET: Hotels/Create
        public IActionResult Create()
        {
            return View();
        }
        //POST: Hotels/Create/hotel
        [HttpPost]
        [ActionName("Create")]
        public async Task<IActionResult> ConfirmCreate(Hotel hotel)
        {
            if (ModelState.IsValid)
            {
                await _hotels.CreateHotel(hotel);
                return RedirectToAction("Index");
            }
            return View(hotel);
        }
    }
}
