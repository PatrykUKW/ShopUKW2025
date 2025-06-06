﻿using Microsoft.AspNetCore.Mvc;
using ShopUKW2025.DAL;
using ShopUKW2025.Models;
using System.Diagnostics;

namespace ShopUKW2025.Controllers
{
    public class HomeController : Controller
    {
        FilmsContext db;

        public HomeController(FilmsContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var categories = db.Categories.ToList();

            return View(categories);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult FooterSites(string siteName)
        {

            return View(siteName);
        }

        
    }
}