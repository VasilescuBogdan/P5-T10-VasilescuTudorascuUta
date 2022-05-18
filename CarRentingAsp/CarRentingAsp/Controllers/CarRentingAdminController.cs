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
    [Authorize(Roles = "Admin")]
    public class CarRentingAdminController : Controller
    {
       
        private CarService _carService;
        private UserService _userService;
       
        private Car_CategoryService _car_CategoryService;


        public CarRentingAdminController(Car_CategoryService Car_CategoryService,CarService carService,UserService userService)
        {
            
           _carService = carService;
            _userService = userService;
            
            _car_CategoryService = Car_CategoryService;
        }

        // GET: CarRenting/Create
       
        public IActionResult IndexAdmin()
        {

            return View();
            
        }
     

        public IActionResult AddVehicleAdmin()
        {
            ViewData["Car_CategoryId"] = new SelectList(_car_CategoryService.GetCar_Category(), "Car_CategoryId", "Car_CategoryId");
        
            return View();
        }
        public IActionResult AddCarCategoryAdmin()
        {

            return View();
        }
        public IActionResult SeeVehicleAdmin()
        {
            var vehicle = _carService.GetCar();
            return View(vehicle);
        }
       

        
       
        public IActionResult SeeCarCategoryAdmin()
        {
            var car_category=_car_CategoryService.GetCar_Category();
            return View(car_category);
        }
        public IActionResult SeeUserAdmin()
        {
            var users = _userService.GetUsers();
            return View(users);
        }



        public IActionResult AddVehicle([Bind("CarId,Make,Model,Model_Year,Mileage,Registration_Number,Status,Price_Hour,Price_Day,Price_Month,Fee_Per_Hour,Fuel,Transmission,Traction,Lenght,Width,Height,Trunk,Engine,Displacement,Fuel_System,Horsepower,Torque,Consumption_Urban,Consumption_Extra_Urban,Consumption_Combine,Acceleration,Max_Speed,Imagine_Name,Car_CategoryId")] Car car)
        {


            _carService.AddCar(car);
            _carService.Save();

            ViewData["Car_CategoryId"] = new SelectList(_car_CategoryService.GetCar_Category(), "Car_CategoryId", "Car_CategoryId");
            ViewData["Name"] = new SelectList(_car_CategoryService.GetCar_Category(), "Name", "Name");
            return RedirectToAction(nameof(SeeVehicleAdmin));
            
            
        }

        public IActionResult EditVehicleAdmin(int? id)
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
        public IActionResult EditVehicleAdmin(int id, [Bind("CarId,Make,Model,Model_Year,Mileage,Registration_Number,Status,Price_Hour,Price_Day,Price_Month,Fee_Per_Hour,Fuel,Transmission,Traction,Lenght,Width,Height,Trunk,Engine,Displacement,Fuel_System,Horsepower,Torque,Consumption_Urban,Consumption_Extra_Urban,Consumption_Combine,Acceleration,Max_Speed,Imagine_Name,Car_CategoryId")] Car car)
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
                
                return RedirectToAction(nameof(IndexAdmin));
            }
            

        }

        public IActionResult DeleteVehicleAdmin(int? id)
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

        // POST: Blogs/Delete/5
        [HttpPost, ActionName("DeleteVehicleAdmin")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteVehicleAdminConfirmed(int id)
        {
            var car = _carService.GetCarByCondition(b=>b.CarId==id).FirstOrDefault();
            _carService.DeleteCar(car);
            _carService.Save();
            return RedirectToAction(nameof(IndexAdmin));
        }

        private bool CarExists(int id)
        {
            return _carService.GetCar().Any(e => e.CarId == id);
        }


        public IActionResult AddCarCategory([Bind("Car_CategoryId,Name,Seats,Luggage")] Car_Category car_Category)
        {

            _car_CategoryService.AddCar_Category(car_Category);
            _car_CategoryService.Save();


            return RedirectToAction(nameof(SeeCarCategoryAdmin));
        }

        public IActionResult DeleteUserAdmin(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = _userService.GetUsers().FirstOrDefault(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Blogs/Delete/5
        [HttpPost, ActionName("DeleteUserAdmin")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteUserAdminConfirmed(string id)
        {
            var user = _userService.GetUsersByCondition(b => b.Id == id).FirstOrDefault();
            _userService.DeleteUser(user);
            _userService.Save();
            return RedirectToAction(nameof(SeeUserAdmin));
        }

        private bool UserExists(string id)
        {
            return _userService.GetUsers().Any(e => e.Id == id);
        }

    }



}