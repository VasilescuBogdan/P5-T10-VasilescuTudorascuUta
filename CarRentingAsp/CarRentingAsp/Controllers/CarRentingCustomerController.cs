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

namespace CarRentingAsp.Controllers
{
    [Authorize(Roles = "Customer")]
    public class CarRentingCustomerController : Controller
    {
       
        private CarService _carService;
       private ContactService _contactService;
        private ReviewService _reviewService;
        public CarRentingCustomerController(CarService carService,ContactService contactService,ReviewService reviewService)
        {
           
            _carService = carService;
            _contactService = contactService;
            _reviewService = reviewService;
        }
        public IActionResult IndexCustomer()
        {
            
            return View();
        }
        public IActionResult ServiceCustomer()
        {
            return View();
        }
        public IActionResult ContactCustomer()
        {
            return View();
        }
        public IActionResult ReviewCustomer()
        {
            return View();
        }
     
        public IActionResult AboutCustomer()
        {
            return View();
        }
        public IActionResult PricingCustomer()
        {
            var car = _carService.GetCar();
            return View(car);
        }
        public IActionResult CarCustomer()
        {
            var car=_carService.GetCar();
            return View(car);
        }

        public IActionResult CarDetailCustomer(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = _carService.GetCar().FirstOrDefault(m => m.CarId == id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ContactCustomer([Bind("ContactId,Name,Email,Subject,Message")] Contact contact)
        {
            _contactService.AddContact(contact);
            _contactService.Save();

            return RedirectToAction(nameof(IndexCustomer));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ReviewCustomer([Bind("ReviewId,Message,CustomerId")] Review review)
        {
            _reviewService.AddReview(review);
            _reviewService.Save();

            return RedirectToAction(nameof(IndexCustomer));
        }



    }
}
