﻿using RestaurantRaterMVC.Models;
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
    }
}