using Microsoft.AspNetCore.Mvc;
using MVCTestFormApp.Data;
using MVCTestFormApp.Models;
using System;
using System.Text.Encodings.Web;

namespace MVCTestFormApp.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserRepo _repository;

        public UsersController(IUserRepo repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            _repository.CreateUser(user);
            _repository.SaveChanges();

            return View();
        }
    }
}