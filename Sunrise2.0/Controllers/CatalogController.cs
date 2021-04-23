using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Sunrise2._0.Models;
using Sunrise2._0.Manager;
using Sunrise2._0.Storage.Entity;
using Sunrise2._0.Manager.OrderManager;
using Sunrise2._0.Manager.TourManager;

namespace Sunrise2._0.Controllers
{
    public class CatalogController : Controller
    {
        private IOrderManager _managerorder;
        private ITourManager _managertour;


        public CatalogController(IOrderManager manager1,ITourManager manager2)
        {
            _managerorder = manager1;
            _managertour = manager2;


        }

        public IActionResult Index()
        {
            
            var toursname = _managertour;
            toursname.GetAll();
          
            //_managertour.addname(toursname); // ошибка какая то
            ViewBag.Tourforview = toursname;
            return View();
        }
        [HttpGet]
        public IActionResult Buy()
        {
            int id = 5;
            ViewBag.TourId = id;
            return View();
        }


        [HttpPost]
        public string Buy(Order purch)
        {
            
            _managerorder.add(purch);

            
            return "Спасибо," + purch.Date + ", за покупку ";
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
