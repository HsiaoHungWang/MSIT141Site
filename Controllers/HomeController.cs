using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MSIT141Site.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MSIT141Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DemoContext _context;

        public HomeController(ILogger<HomeController> logger, DemoContext conetxt)
        {
            
            _logger = logger;
            _context = conetxt;
        }

        public IActionResult Index()
        {
           
            return View();
        }

        public IActionResult FirstAjax()
        {
            return View();
        }

        public IActionResult AjaxPost()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Address()
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
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
