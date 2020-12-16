using Microsoft.AspNetCore.Mvc;
using Places.Models;
using System.Collections.Generic;

namespace Places.Controllers
{

    public class PlacesController : Controller
    {
        [HttpGet("/places")]
        public ActionResult Index()
        {
            List<Place> allPlaces = Place.GetAll();
            return View(allPlaces);
        }

        [HttpGet("/places/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpGet("/places/{id}")]
        public ActionResult Show(int Id)
        {
            Place foundPlace = Place.Find(Id);
            return View(foundPlace);
        }

        [HttpPost("/places")]
        public ActionResult Create(string location, string description, string duration)
        {
            Place myPlace = new Place(location, description, duration);
            return RedirectToAction("Index");
        }

        [HttpPost("/places/delete")]
        public ActionResult DeleteAll()
        {
            Place.ClearAll();
            return View();
        }
    }
}