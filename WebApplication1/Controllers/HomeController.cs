﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Student()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Student(Student model)
        {
            return View();
        }
    }
}
