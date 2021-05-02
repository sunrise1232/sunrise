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
            IEnumerable<Tour> tours;
            IEnumerable<Tour> tours1;



            tours = _managertour.GetAll().OrderByDescending(t => t.Rating);

           tours1 = tours.ToList().GetRange(0, 5);




            return View(tours);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
