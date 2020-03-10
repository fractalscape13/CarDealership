using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;

namespace CarDealership.Controllers
{
    public class SearchController : Controller
    {

        [HttpGet("/search")]
        public ActionResult Index()
        {
            List<Car> validCars = Car.GetAllValidCars();
            return View(validCars);
        }

        [HttpGet("/search/new")]
        public ActionResult SearchForm()
        {
            return View();
        }

        [HttpPost("/search")]
        public ActionResult Create(int maxMiles, int maxPrice)
        {
            List<Car> allCars = Car.GetAll();
            foreach (Car car in allCars)
            {
                if (car.MeetCriteria(maxMiles, maxPrice))
                {
                    car.SetValidCars();
                }
            }
            return RedirectToAction("Index");
        }
    }
}