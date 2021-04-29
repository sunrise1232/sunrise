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
using Sunrise2._0.Data;

namespace Sunrise2._0.Controllers
{
    public class CatalogController : Controller
    {
        private IOrderManager _managerorder;
        private ITourManager _managertour;


        public CatalogController(IOrderManager manager1, ITourManager manager2)
        {
            _managerorder = manager1;
            _managertour = manager2;


        }

        public IActionResult Index()
        {

            /*var toursname = _managertour;
            toursname.GetAll();

            _managertour.addname(toursname); // ошибка какая то
            ViewBag.Tourforview = toursname;
            return View();*/

            var tours = _managertour.GetAll();
            
            return View(tours);
        }


        [HttpGet]
        public IActionResult Buy(int TourId)
        {

            var tour = _managertour.GetAll().FirstOrDefault(t => t.Id == TourId);
            

            return View(tour);

        }


        [HttpPost]
        public string Buy(Order purch)
        {
            _managerorder.Add(purch);


            return "Спасибо," + purch.Date + ", за покупку ";
        }



        /*SunriseContext _context;

         public CatalogController(SunriseContext context)
         {
             _context = context;
         }

         public ActionResult Index()
         {
             ViewBag.Tours = _context.Tours;
             ViewBag.Hotels = _context.Hotels;

             return View();
         }*/
    }
}
