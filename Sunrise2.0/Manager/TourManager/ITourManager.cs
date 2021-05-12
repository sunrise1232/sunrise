using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sunrise2._0.Storage.Entity;

namespace Sunrise2._0.Manager.TourManager
{
    public interface ITourManager
    {

        public Task Add(Tour Tour);

        public Task AddImage(byte[] Data, int TourId);
        public Task Delete(Tour Tour);
        public Task Edit(int TourId, string Description, int Price);
        public Tour FindTour(int id);
        public Task<ICollection<Tour>> GetAll();
        public Image GetImage(int id);
        public Task<ICollection<Image>> GetImages(int id);
        public Task IncRating(int TourId);

        public Task<ICollection<Tour>> SearchManager(string Name);



    }


}
