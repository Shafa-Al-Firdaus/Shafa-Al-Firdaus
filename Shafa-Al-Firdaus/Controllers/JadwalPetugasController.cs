﻿using Microsoft.AspNetCore.Mvc;
using Shafa_Al_Firdaus.Models;
using System.Diagnostics;

namespace Shafa_Al_Firdaus.Controllers
{
    public class JadwalPetugasController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public JadwalPetugasController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.DisplayName ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Update(string Id)
        {
            ViewBag.Id = Id;
            return View();
        }
    }
}