﻿using OdeToFood.Data.Models;
using OdeToFood.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class RestaurantsController : Controller
    {
        public IRestaurantData RestaurantsData { get; }

        public RestaurantsController(IRestaurantData restaurantsData)
        {
            RestaurantsData = restaurantsData;
        }
        // GET: Restaurants
        public ActionResult Index()
        {
            var model = RestaurantsData.GetAll();
            return View(model);
        }
        public ActionResult Details(int id)
        {
            var model = RestaurantsData.Get(id);
            if(model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Restaurant restaurant)
        {
            if (string.IsNullOrEmpty(restaurant.Name))
            {
                ModelState.AddModelError(nameof(restaurant.Name), "Error");
            }
            else
            {
                RestaurantsData.Add(restaurant); 
                return View();
            }
            return View();
        }
    }
}