using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;

namespace CarDealership.Controllers
{
    public class ItemsController : Controller
    {

        [HttpGet("/cars")]
        public ActionResult Index()
        {
        List<Item> allItems = Item.GetAll();
        return View(allItems);
        }

        [HttpGet("/cars/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/cars")]
        public ActionResult Create(string makeModel, int price, int miles, string info)
        {
            Car newCar = new Car(makeModel, price, miles, info);
            return RedirectToAction("Index");
        }
    }
}