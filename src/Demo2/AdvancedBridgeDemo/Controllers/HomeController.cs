using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AdvancedBridgeDemo.Models;
using AdvancedBridgeDemo.Configuration;

namespace AdvancedBridgeDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMyAppSettings _settings;

        public HomeController(IMyAppSettings settings)
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
