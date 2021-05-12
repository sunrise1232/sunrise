using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Sunrise2._0.Models;
using Sunrise2._0.Manager.TourManager;
using Sunrise2._0.Storage.Entity;

namespace Sunrise2._0.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

      
         
            private ITourManager _managertour;
           
         
      
            public HomeController(ILogger<HomeController> logger, ITourManager manager2)
        {
            _logger = logger;
                _managertour = manager2;
            }

     

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Index()
        {
            List<Tour> tours;
            try
            {
                tours = _managertour.GetAll().Result.OrderByDescending(t => t.Rating).ToList().GetRange(0, 2);
            }
            catch {
                tours = _managertour.GetAll().Result.ToList();
            }
            

            return View(tours);
        }


        public IActionResult GetImage(int id)
        {
            var image = _managertour.GetImage(id);
            if (image == null)
            {
                return NotFound();
            }
            return File(image.Data, "image/png");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
