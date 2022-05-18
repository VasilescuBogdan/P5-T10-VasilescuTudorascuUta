#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarRentingAsp.Models;
using System.Dynamic;
using CarRentingAsp.Repositories.Interfaces;
using CarRentingAsp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace CarRentingAsp.Controllers
{
   [AllowAnonymous]
    public class CarRentingGuestController : Controller
    {
        private CarService _carService;
        private ContactService _contactService;

        public CarRentingGuestController(CarService carService, ContactService contactService)
        {
            _carService = carService;
           
            _contactService = contactService;
        }

        public IActionResult IndexGuest()
        {
            return View();
        }
        public IActionResult AboutGuest()
        {
            return View();
        }
        public IActionResult ContactGuest()
        {
            return View();
        }
        
        public IActionResult ServiceGuest()
        {
            return View();
        }
        public IActionResult RegisterGuest()
        {
            return View();
        }
        public IActionResult PricingGuest()
        {
            var car = _carService.GetCar();
            return View(car);
        }
        public IActionResult CarGuest()
        {
            var car=_carService.GetCar();
            return View(car);
        }

        public IActionResult CarDetailGuest(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car =  _carService.GetCar().FirstOrDefault(m => m.CarId == id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

      

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ContactGuest([Bind("ContactId,Name,Email,Subject,Message")] Contact contact)
        {
            _contactService.AddContact(contact);
            _contactService.Save();

            return RedirectToAction(nameof(IndexGuest));
        }

    }
}