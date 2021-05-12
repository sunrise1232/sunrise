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
    public class TourManager : ITourManager
    {


        private SunriseContext _ContextTour;




        public TourManager(SunriseContext context)
        {
            _ContextTour = context;
        }

        public async Task AddImage(byte[] Data, int TourId)
        {
            Image Image = new Image();
            Image.Data = Data;
            Image.TourId = TourId;
            await _ContextTour.Images.AddAsync(Image);
            await _ContextTour.SaveChangesAsync();
        }



        public async Task Add(Tour Tour)
        {
            await _ContextTour.AddAsync(Tour);
            await _ContextTour.SaveChangesAsync();
        }

        public async Task Delete(Tour Tour)
        {

            _ContextTour.Tours.Remove(Tour);
            await _ContextTour.SaveChangesAsync();
        }

        public async Task Edit(int TourId, string Description, int Price)
        {
            Tour r = _ContextTour.Tours.First(d => d.Id == TourId);
            r.Description = Description;
            r.Price = Price;
            await _ContextTour.SaveChangesAsync();
        }


        public Tour FindTour(int id)
        {

            Tour r = _ContextTour.Tours.First(d => d.Id == id);

            return r;
        }


        public async Task IncRating(int TourId)
        {
            var Tour = _ContextTour.Tours.FirstOrDefault(i => i.Id == TourId);
            Tour.Rating++;
            await _ContextTour.SaveChangesAsync();
        }

        public async Task<ICollection<Tour>> GetAll()
        {
            return await _ContextTour.Tours.Include(t => t.Hotel.Town.Region).ToListAsync();
        }

        public Image GetImage(int id)
        {
            return _ContextTour.Images.FirstOrDefault(i => i.TourId == id);
        }

        public async Task<ICollection<Image>> GetImages(int id)
        {
            return await _ContextTour.Images.Where(i => i.TourId == id).ToListAsync();
        }


        public async Task<ICollection<Tour>> SearchManager(string Name)
        {
            return await _ContextTour.Tours.Include(t => t.Hotel.Town.Region).Where(t => t.Hotel.Town.Name == Name).ToListAsync();
        }


    }
}
