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
namespace CarRentingAsp.Controllers
{
    public class CarRentingController : Controller
    {
        private readonly CarRentingContext _context;

        public CarRentingController(CarRentingContext context)
        {
            _context = context;
        }

        // GET: CarRenting/Create
        public IActionResult IndexCustomer()
        {
            return View();
        }
        public async Task<IActionResult> IndexAdmin()
        {
            
                return View(await _context.Admins.ToListAsync());
            
        }
        public IActionResult Register()
        {
            
            return View();
        }
        public IActionResult AddVehicleAdmin()
        {
            return View();
        }
        public async Task<IActionResult> SeeVehicleAdmin()
        {
            return View(await _context.Cars.ToListAsync());
        }
        public async Task<IActionResult> Car()
        {
            return View(await _context.Cars.ToListAsync());
        }
        public IActionResult AddEmployerAdmin()
        {
            return View();
        }
        public async Task<IActionResult> SeeEmployerAdmin()
        {
            return View(await _context.Employees.ToListAsync());
        }

        // POST: CarRenting/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register([Bind("CustomerId,First_Name,Last_Name,Username,Email,Password,Birth_Date,Driver_License")] Customer customer)
        {
           
            
                _context.Add(customer);
                await _context.SaveChangesAsync();


            return RedirectToAction(nameof(IndexCustomer));
        }

        public async Task<IActionResult> AddVehicle([Bind("CarId,Make,Model,Model_Year,Mileage,Registration_Number,Status,Price_Hour,Price_Day,Price_Month,Fee_Per_Hour,Fuel,Transmission,Traction,Lenght,Width,Height,Trunk,Engine,Displacement,Fuel_System,Horsepower,Torque,Consumption_Urban,Consumption_Extra_Urban,Consumption_Combine,Acceleration,Max_Speed,Imagine_Name,Car_CategoryId")] Car car)
        {


            _context.Add(car);
            await _context.SaveChangesAsync();


            return RedirectToAction(nameof(SeeVehicleAdmin));
        }

        public async Task<IActionResult> EditVehicleAdmin(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Cars.FindAsync(id);
            if (car == null)
            {
                return NotFound();
            }
            return View(car);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditVehicleAdmin(int id, [Bind("CarId,Make,Model,Model_Year,Mileage,Registration_Number,Status,Price_Hour,Price_Day,Price_Month,Fee_Per_Hour,Fuel,Transmission,Traction,Lenght,Width,Height,Trunk,Engine,Displacement,Fuel_System,Horsepower,Torque,Consumption_Urban,Consumption_Extra_Urban,Consumption_Combine,Acceleration,Max_Speed,Imagine_Name,Car_CategoryId")] Car car)
        {
            if (id != car.CarId)
            {
                return NotFound();
            }
            else
            {
                _context.Update(car);
                await _context.SaveChangesAsync();


                return RedirectToAction(nameof(IndexAdmin));
            }
            
            
        }

        public async Task<IActionResult> DeleteVehicleAdmin(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Cars
                .FirstOrDefaultAsync(m => m.CarId == id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

        // POST: Blogs/Delete/5
        [HttpPost, ActionName("DeleteVehicleAdmin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteVehicleAdminConfirmed(int id)
        {
            var car = await _context.Cars.FindAsync(id);
            _context.Cars.Remove(car);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexAdmin));
        }

        private bool CarExists(int id)
        {
            return _context.Cars.Any(e => e.CarId == id);
        }

        public async Task<IActionResult> CarDetail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Cars
                .FirstOrDefaultAsync(m => m.CarId == id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

        public async Task<IActionResult> AddEmployer([Bind("EmployerId,First_Name,Last_Name,Username,Email,Password,Program_HourId,SalaryId")] Employer employer)
        {


            _context.Add(employer);
            await _context.SaveChangesAsync();


            return RedirectToAction(nameof(SeeEmployerAdmin));
        }


        public async Task<IActionResult> EditEmployerAdmin(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employer = await _context.Employees.FindAsync(id);
            if (employer == null)
            {
                return NotFound();
            }
            return View(employer);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditEmployerAdmin(int id, [Bind("EmployerId,First_Name,Last_Name,Username,Email,Password,Program_HourId,SalaryId")] Employer employer)
        {
            if (id != employer.EmployerId)
            {
                return NotFound();
            }
            else
            {
                _context.Update(employer);
                await _context.SaveChangesAsync();


                return RedirectToAction(nameof(SeeEmployerAdmin));
            }


        }

        public async Task<IActionResult> DeleteEmployerAdmin(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employer = await _context.Employees
                .FirstOrDefaultAsync(m => m.EmployerId == id);
            if (employer == null)
            {
                return NotFound();
            }

            return View(employer);
        }

        // POST: Blogs/Delete/5
        [HttpPost, ActionName("DeleteEmployerAdmin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteEmployerAdminConfirmed(int id)
        {
            var employer = await _context.Employees.FindAsync(id);
            _context.Employees.Remove(employer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(SeeEmployerAdmin));
        }

        private bool EmployerExists(int id)
        {
            return _context.Employees.Any(e => e.EmployerId == id);
        }

       
    }



}
