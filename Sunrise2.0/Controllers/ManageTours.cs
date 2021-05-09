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
    public class ManageTours : Controller
    {
        private ITourManager _managertour;



        public ManageTours(ITourManager manager1)
        {
            _managertour = manager1;

        }


        public IActionResult Index()
        {

            return View();
        }


        [HttpPost]
        public IActionResult Add1(Tour Tour)
        {
            Tour.Rating = 0;
            Tour.HotelId = 1;
            _managertour.Add(Tour);


            return View();
        }
    }
}
