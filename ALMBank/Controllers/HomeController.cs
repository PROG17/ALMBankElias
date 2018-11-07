﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ALMBank.Models;

namespace ALMBank.Controllers
{
    public class HomeController : Controller
    {
        private BankRepository _repo;

        public HomeController(BankRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View(_repo);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
