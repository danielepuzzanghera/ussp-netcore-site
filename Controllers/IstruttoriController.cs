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
    public class IstruttoriController : Controller
    {
        private readonly ILogger<IstruttoriController> _logger;

        public IstruttoriController(ILogger<IstruttoriController> logger)
        {
            _logger = logger;
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult Istruttori()
        {
            return View();
        }
    }
}
