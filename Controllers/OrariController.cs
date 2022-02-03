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
    public class OrariController : Controller
    {
        private readonly ILogger<OrariController> _logger;

        public OrariController(ILogger<OrariController> logger)
        {
            _logger = logger;
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Orari()
        {
            return View();
        }

    }
}
