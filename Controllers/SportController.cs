using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UnioneSportiva.Models;

namespace UnioneSportiva.Controllers
{
    public class SportController : Controller
    {
        private readonly ILogger<SportController> _logger;

        public SportController(ILogger<SportController> logger)
        {
            _logger = logger;
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult JuJitsu()
        {
            return View();
        }

        public IActionResult Judo()
        {
            return View();
        }

        public IActionResult Karate()
        {
            return View();
        }

        public IActionResult Pugilato()
        {
            return View();
        }

        public IActionResult Yoga()
        {
            return View();
        }

        public IActionResult Lotta()
        {
            return View();
        }

    }
}
