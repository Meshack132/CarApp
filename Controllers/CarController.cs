using Microsoft.AspNetCore.Mvc;
using CarApp.Models; // Assuming the models namespace

namespace CarApp.Controllers
{
    public class CarController : Controller
    {
        // This is just an example list, you may fetch it from a database
        private static List<Car> cars = new List<Car>
        {
            new Car { Id = 1, Make = "Toyota", Model = "Corolla" },
            new Car { Id = 2, Make = "Honda", Model = "Civic" }
        };

        public IActionResult Index()
        {
            // Passing the list of cars to the view
            return View(cars);
        }
    }
}
