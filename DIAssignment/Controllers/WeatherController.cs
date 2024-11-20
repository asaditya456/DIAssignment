﻿using Microsoft.AspNetCore.Mvc;
using Services;

namespace DIAssignment.Controllers
{
    public class WeatherController : Controller
    {
        private readonly IWeatherService weatherService;

        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
