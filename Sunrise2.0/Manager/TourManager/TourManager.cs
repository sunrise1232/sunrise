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





        public void Add(Tour Tour)
        {
            _ContextTour.Add(Tour);
            _ContextTour.SaveChanges();
        }

        public void Delete(Tour Tour)
        {

            _ContextTour.Tours.Remove(Tour);
            _ContextTour.SaveChanges();
        }

        public void Edit(int TourId, string Description, int Price)
        {
            Tour r = _ContextTour.Tours.First(d => d.Id == TourId);
            r.Description = Description;
            r.Price = Price;
            _ContextTour.SaveChanges();


        }


        public Tour FindTour(int id)
        {

            Tour r = _ContextTour.Tours.First(d => d.Id == id);

            return r;
        }


        public void IncRating(int TourId)
        {
            var Tour = _ContextTour.Tours.FirstOrDefault(i => i.Id == TourId);
            Tour.Rating++;
            _ContextTour.SaveChanges();
        }

        public ICollection<Tour> GetAll()
        {
            return  _ContextTour.Tours.Include(t => t.Hotel.Town.Region).ToList();
        }

        public Image GetImage(int id)
        {
            return _ContextTour.Images.FirstOrDefault(i => i.TourId == id);
        }

        public ICollection<Image> GetImages(int id)
        {
            return _ContextTour.Images.Where(i => i.TourId == id).ToList();
        }


        public ICollection<Tour> SearchManager(string Name)
        {
            return _ContextTour.Tours.Include(t => t.Hotel.Town.Region).Where(t => t.Hotel.Town.Name == Name).ToList();
        }


    }
}
