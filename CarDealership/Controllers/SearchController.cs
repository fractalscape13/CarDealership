using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;

namespace CarDealership.Controllers
{
    public class ItemsController : Controller
    {

        [HttpGet("/search")]
        public ActionResult Index()
        {
        List<Item> allItems = Item.GetAll();
        return View(allItems);
        }

        [HttpGet("/search/new")]
        public ActionResult SearchForm()
        {
            return View();
        }

        [HttpPost("/search")]
        public ActionResult Create(string description)
        {
            Item myItem = new Item(description);
            return RedirectToAction("Index");
        }
    }
}