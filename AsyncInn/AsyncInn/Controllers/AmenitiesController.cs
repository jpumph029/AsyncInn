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

        public async Task<IActionResult> Index()
        {
            
            return View(await _amenities.GetAmenities());
        }       
        
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return View();

            }
            
            return View(await _amenities.GetAmenities(id));
        }
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult Delete(int id)
        {

            _amenities.DeleteAmenities(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NoContent();
            }
            
            return View(await _amenities.GetAmenities(id));
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return View();
            }
            return View(await _amenities.GetAmenities(id));
        }
        [HttpPost]
        [ActionName("Edit")]
        public IActionResult ConfirmEdit(Amenities amenities)
        {
            _amenities.UpdateAmenities(amenities);
            return RedirectToAction("Index");
        }


        public IActionResult Create()
        {
            return View();
        }
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
