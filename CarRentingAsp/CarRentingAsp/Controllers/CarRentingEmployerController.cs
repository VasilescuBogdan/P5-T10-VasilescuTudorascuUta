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
    [Authorize(Roles = "Employer")]
    public class CarRentingEmployerController : Controller
    {
       
        private CarService _carService;
        
        private ContactService _contactService;
        private Car_CategoryService _car_CategoryService;
        public  CarRentingEmployerController(Car_CategoryService Car_CategoryService, CarService carService, ContactService contactService)
        {
            _carService = carService;
            
            _contactService = contactService;
            _car_CategoryService = Car_CategoryService;
            
        }
        public IActionResult IndexEmployer()
        {
            return View();
        }
        public IActionResult SeeCarEmployer()
        {
            var car = _carService.GetCar();
            return View(car);
        }
        public IActionResult SeeQuestionEmployer()
        {
            var contact = _contactService.GetContact();
            return View(contact);
        }
        public IActionResult EditCarEmployer(int? id)
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
            ViewData["Car_CategoryId"] = new SelectList(_car_CategoryService.GetCar_Category(), "Car_CategoryId", "Car_CategoryId");
            return View(car);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditCarEmployer(int id, [Bind("CarId,Make,Model,Model_Year,Mileage,Registration_Number,Status,Price_Hour,Price_Day,Price_Month,Fee_Per_Hour,Fuel,Transmission,Traction,Lenght,Width,Height,Trunk,Engine,Displacement,Fuel_System,Horsepower,Torque,Consumption_Urban,Consumption_Extra_Urban,Consumption_Combine,Acceleration,Max_Speed,Imagine_Name,Car_CategoryId")] Car car)
        {
            if (id != car.CarId)
            {
                return NotFound();
            }
            else
            {
                _carService.UpdateCar(car);
                _carService.Save();

                ViewData["Car_CategoryId"] = new SelectList(_car_CategoryService.GetCar_Category(), "Car_CategoryId", "Car_CategoryId");
                return RedirectToAction(nameof(IndexEmployer));
            }


        }
    }
}
