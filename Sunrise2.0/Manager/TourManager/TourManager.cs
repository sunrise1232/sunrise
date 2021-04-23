using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public Tour addname(Tour name)
        {
            name.Name= "Dagestan";
            return name;
           
        }

        public ICollection<Tour> GetAll() => _ContextTour.Tours.ToList();

        public ICollection<Tour> Index11()
        {
            return _ContextTour.Tours.ToList();
        }

        void ITourManager.addname(Tour tour)
        {
            throw new NotImplementedException();
        }
    }
}
