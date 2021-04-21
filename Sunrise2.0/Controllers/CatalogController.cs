using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Sunrise2._0.Models;
using Sunrise2._0.Storage;
using Sunrise2._0.Data;

namespace Sunrise2._0.Controllers
{
    public class CatalogController : Controller
    {
        private readonly SunriseContext _context;

        public CatalogController(SunriseContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var Tours = _context.Tours;
            ViewBag.Tours = Tours;
            
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
