﻿using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Index()
        {

            var tours = _managertour.GetAll();
            
            return View(tours);
        }

 

        [HttpPost]
        public IActionResult Search(string Name)
        {

            var tour = _managertour.SearchManager(Name);

            return View(tour);
        }



        [HttpGet]
        public IActionResult Buy(int TourId)
        {

            var tour = _managertour.GetAll().FirstOrDefault(t => t.Id == TourId);
            ViewBag.Airlines = _managerAirline.GetAll();
            

            return View(tour);

        }


        [HttpPost]
        public string Buy(Order purch)
        {
            ClaimsPrincipal currentUser = this.User;
            purch.ClientId = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            purch.AirlineId = 1;
            _managerorder.Add(purch);
             


            return $"thanks, {User.Identity.Name}";
            // return View(purch);
        }


        [HttpPost]
        public IActionResult RaitingSortUp()
        {
            var tour = _managertour.GetAll().OrderBy(t => t.Rating);
            return View(tour);
        }

        [HttpPost]
        public IActionResult RaitingSortDown()
        {
            var tour = _managertour.GetAll().OrderByDescending(t => t.Rating);
            return View(tour);
        }

        [HttpPost]
        public IActionResult PriseSortDown()
        {
            var tour = _managertour.GetAll().OrderByDescending(t => t.Price);
            return View(tour);
        }

        [HttpPost]
        public IActionResult PriseSortUp()
        {
            var tour = _managertour.GetAll().OrderBy(t => t.Price);
            return View(tour);
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
