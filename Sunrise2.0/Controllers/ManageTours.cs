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


        public IActionResult Add()
        {

            return View();
        }


        [HttpPost]
        public IActionResult Add(string Description1, string HotelName1, string TownName1, string RegionName1, int Price1)
        {

            Tour Tour = new Tour();

            Tour.Description = Description1;

            int idregion;
            try
            {  idregion = _managerregion.FindRegion(RegionName1); }
            catch
            {
                _managerregion.Add(RegionName1);
                 idregion = _managerregion.FindRegion(RegionName1);
            }



            int idtown;
            try
            { idtown = _managertowns.FindTowns(TownName1, idregion); }
            catch
            {
                _managertowns.Add(TownName1, idregion);
                idtown = _managertowns.FindTowns(TownName1, idregion);
            }

            int idHotel;
            try
            { idHotel = _managerhotel.FindHotel(HotelName1, idtown); }
            catch
            {
                _managerhotel.Add(HotelName1, idtown);
                idHotel = _managerhotel.FindHotel(HotelName1, idtown);
            }

            Tour.HotelId = idHotel;
         
            
            Tour.Price = Price1;

            _managertour.Add(Tour);


            return View();
        }
    }
}
