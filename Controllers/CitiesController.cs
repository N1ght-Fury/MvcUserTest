using Microsoft.AspNetCore.Mvc;
using MVCTestFormApp.Data;
using MVCTestFormApp.Models;
using System;
using System.Collections.Generic;
using System.Text.Encodings.Web;

namespace MVCTestFormApp.Controllers
{
    public class CitiesController : Controller
    {
        private readonly ICityRepo _repository;

        public CitiesController(ICityRepo repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            /* IEnumerable<City> cityList = _repository.GetAllCities();
            ViewBag.ListOfCities = cityList; */
            return View();
        }
    }
}