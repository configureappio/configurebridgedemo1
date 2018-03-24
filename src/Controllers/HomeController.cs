using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleBridgeDemo.Models;

namespace SimpleBridgeDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyAppSettings _settings;

        public HomeController(MyAppSettings settings)
        {
            _settings = settings ?? throw new ArgumentNullException(nameof(settings));
        }
        public IActionResult Index()
        {
            return View(_settings);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
