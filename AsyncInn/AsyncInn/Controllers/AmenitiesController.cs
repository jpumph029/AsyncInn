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
    public class AmenitiesController : Controller 
    {
        private IAmenitiesManager _amenities { get; }

        
        public AmenitiesController(IAmenitiesManager db)
        {
            _amenities = db;
        }

        //Get: Amenetites/Index
        public async Task<IActionResult> Index()
        {
            
            return View(await _amenities.GetAmenities());
        }       
        
        //GEt: Ameneties/Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return View();

            }
            
            return View(await _amenities.GetAmenities(id));
        }
        //POST: Ameneties/Delete/ID
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult Delete(int id)
        {

            _amenities.DeleteAmenities(id);
            return RedirectToAction("Index");
        }
        //GET: Ameneties/Details/ID
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NoContent();
            }
            
            return View(await _amenities.GetAmenities(id));
        }
        //GET: Ameneties/Edit/ID
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return View();
            }
            return View(await _amenities.GetAmenities(id));
        }
        //POST: Ameneties/Edit/ID
        [HttpPost]
        [ActionName("Edit")]
        public IActionResult ConfirmEdit(Amenities amenities)
        {
            _amenities.UpdateAmenities(amenities);
            return RedirectToAction("Index");
        }

        //GET: Ameneties/Create
        public IActionResult Create()
        {
            return View();
        }

        //POST: Ameneties/Create/ID
        [HttpPost]
        [ActionName("Create")]
        public async Task<IActionResult> ConfirmCreate(Amenities amenities)
        {
            if (ModelState.IsValid)
            {
                await _amenities.CreateAmenities(amenities);
                return RedirectToAction("Index");
            }
            return View(amenities);
        }
    }
}
