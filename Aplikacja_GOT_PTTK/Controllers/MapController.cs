using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplikacja_GOT_PTTK.Controllers
{
    public class MapController : Controller
    {
        List<(double, double)> l = new List<(double, double)>();
        public IActionResult Index()
        {
            return View();
        }
    }
}
