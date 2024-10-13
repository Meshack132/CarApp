using Microsoft.AspNetCore.Mvc;
using CarApp.Models;
using System.Collections.Generic;

namespace CarApp.Controllers
{
    public class CarController : Controller
    {
        private static List<Car> Cars = new List<Car>
        {
            new Car { Id = 1, Make = "Toyota", Model = "Corolla", Year = 2018 },
            new Car { Id = 2, Make = "Honda", Model = "Civic", Year = 2020 },
            new Car { Id = 3, Make = "Ford", Model = "Focus", Year = 2019 }
        };

        public IActionResult Index()
        {
            return View(Cars);
        }

        public IActionResult Details(int id)
        {
            var car = Cars.Find(c => c.Id == id);
            if (car == null) return NotFound();
            return View(car);
        }
    }
}
