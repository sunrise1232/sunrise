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
using Sunrise2._0.Manager.RegionManager;
using Sunrise2._0.Manager.HotelManager;
using Sunrise2._0.Manager.TownsManager;

namespace Sunrise2._0.Controllers
{
    public class ManageTours : Controller
    {
        private ITourManager _managertour;
        private IRegionManager _managerregion;
        private ITownsManager _managertowns;
        private IHotelManager _managerhotel;




        public ManageTours(ITourManager manager1, IRegionManager manager2, ITownsManager manager3, IHotelManager manager4)
        {
            _managertour = manager1;
            _managerregion = manager2;
            _managertowns = manager3;
            _managerhotel = manager4;

        }

      
        public IActionResult Index()
        {
            IEnumerable<Tour> tours;
            tours = _managertour.GetAll();

            return View(tours);
        }

        [HttpPost]
        public IActionResult Index(int TourId)
        {
                Tour tours = _managertour.FindTour(TourId);

                _managertour.Delete(tours);

                return Redirect("/ManageTours/Index");

        }

        public IActionResult Edit(int TourId)
        {
            ViewBag.TourId = TourId;
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int TourId, string Description, int Price)
        {
            _managertour.Edit(TourId, Description, Price);


            return Redirect("/ManageTours");
        }






        public IActionResult Add()
        {
            return View();
        }


       [HttpPost]
        public IActionResult Add(string Description, string HotelName, string TownName, string RegionName, int Price)
        {
            Tour Tour = new Tour();

            Tour.Description = Description;

            int idregion;
            try
            {  idregion = _managerregion.FindRegion(RegionName); }
            catch
            {
                _managerregion.Add(RegionName);
                 idregion = _managerregion.FindRegion(RegionName);
            }



            int idtown;
            try
            { idtown = _managertowns.FindTowns(TownName, idregion); }
            catch
            {
                _managertowns.Add(TownName, idregion);
                idtown = _managertowns.FindTowns(TownName, idregion);
            }

            int idHotel;
            try
            { idHotel = _managerhotel.FindHotel(HotelName, idtown); }
            catch
            {
                _managerhotel.Add(HotelName, idtown);
                idHotel = _managerhotel.FindHotel(HotelName, idtown);
            }

            Tour.HotelId = idHotel;
         
            
            Tour.Price = Price;

            _managertour.Add(Tour);



                return Redirect("/ManageTours");
        }
    }
}
