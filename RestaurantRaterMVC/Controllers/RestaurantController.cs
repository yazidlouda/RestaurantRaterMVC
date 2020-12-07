using RestaurantRaterMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantRaterMVC.Controllers
{
    public class RestaurantController : Controller
    {

        private RestaurantDbContext _db = new RestaurantDbContext();
        // GET: Restaurant/index
        public ActionResult Index()
        {
            return View(_db.Restaurants.ToList());
        }
        // get:Restaurant/create
        public ActionResult Create()
        {
            return View();
        }
        // Post : Restaurant/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Restaurant restaurant)
        {
            if(ModelState.IsValid)
            {
                _db.Restaurants.Add(restaurant);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(restaurant);
        }
    }
}