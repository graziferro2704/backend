using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Projeto_Aulas.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FrontEndController : Controller
    {
        private readonly ILogger<FrontEndController> _logger;

        public FrontEndController(ILogger<FrontEndController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Camera()
        {
            return View();
        }
        public IActionResult Geolocalizacao()
        {
            return View();
        }
        public IActionResult BuscaCEP()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}