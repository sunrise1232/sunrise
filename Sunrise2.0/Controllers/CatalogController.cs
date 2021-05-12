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
using Microsoft.AspNetCore.Identity;
using Sunrise2._0.Areas.Identity.Data;
using System.Security.Claims;
using Sunrise2._0.Manager.AirlineManger;
using Microsoft.AspNetCore.Authorization;

namespace Sunrise2._0.Controllers
{
    public class CatalogController : Controller
    {
        private IOrderManager _managerorder;
        private ITourManager _managertour;
        private IAirlineManager _managerAirline;
        private readonly UserManager<Client> _managerUser;


        public CatalogController(IOrderManager manager1, ITourManager manager2, IAirlineManager manager3)
        {
            _managerorder = manager1;
            _managertour = manager2;
            _managerAirline = manager3;


        }


        public IActionResult Index(int sort = 0)
        {
            IEnumerable<Tour> tours;

            switch (sort)
            {
                case 1:
                    tours = _managertour.GetAll().Result.OrderBy(t => t.Rating);
                    break;
                case 2:
                    tours = _managertour.GetAll().Result.OrderByDescending(t => t.Rating);
                    break;
                case 3:
                    tours = _managertour.GetAll().Result.OrderBy(t => t.Price);
                    break;
                case 4:
                    tours = _managertour.GetAll().Result.OrderByDescending(t => t.Price);
                    break;
                default:
                    tours = _managertour.GetAll().Result;
                    break;
            }
            ViewBag.Sort = sort;

            return View(tours);
        }

        public IActionResult GetImage(int id)
        {
            var image =  _managertour.GetImage(id);
            if (image == null)
            {
                return NotFound();
            }
            return File(image.Data, "image/png");
        }




        [HttpPost]
        public IActionResult Search(string Name)
        {

            var tour = _managertour.SearchManager(Name);
            ViewBag.Name = Name;

            return View(tour);
        }


        [Authorize]
        [HttpGet]
        public IActionResult Buy(int TourId)
        {

            var tour = _managertour.GetAll().Result.FirstOrDefault(t => t.Id == TourId);
            ViewBag.Airlines = _managerAirline.GetAll();
            ViewBag.Images = _managertour.GetImages(TourId);


            return View(tour);

        }

        

        [HttpPost]
        public IActionResult Buy(Order purch)
        {
            ClaimsPrincipal currentUser = this.User;
            purch.ClientId = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            _managerorder.Add(purch);
            _managertour.IncRating(purch.TourId);




            //return $"thanks, {User.Identity.Name}";
            return RedirectToAction("BuyResult", "Catalog", new { OrderId = purch.Id });
        }

        public IActionResult BuyResult(int OrderId)
        {
            var order = _managerorder.GetAll().Result.FirstOrDefault(t => t.Id == OrderId);

            return View(order);
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
