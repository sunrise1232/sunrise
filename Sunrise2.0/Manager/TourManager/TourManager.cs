using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sunrise2._0.Data;
using Sunrise2._0.Storage;
using Sunrise2._0.Storage.Entity;



namespace Sunrise2._0.Manager.TourManager
{
    public class TourManager:ITourManager
    {


        private SunriseContext _ContextTour;

    
       

        public TourManager(SunriseContext context)
        {
            _ContextTour = context;
        }

      

        //public ICollection<Tour> GetAll() => _ContextTour.Tours.ToList();

        public ICollection<Tour> GetAll()
        {
            return  _ContextTour.Tours.Include(t => t.Hotel.Town.Region).ToList();
        }


    }
}
