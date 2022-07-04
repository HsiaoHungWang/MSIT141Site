using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSIT141Site.Controllers
{
    public class ApiController : Controller
    {
        public IActionResult Index()
        {
            return Content("Ajax, 你好!!","text/plain", System.Text.Encoding.UTF8);
        }
    }
}
