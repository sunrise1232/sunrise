using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sunrise2._0.Storage.Entity;

namespace Sunrise2._0.Manager.TourManager
{
    public interface ITourManager
    {

        public void Add(Tour Tour);

        public void Delete(Tour Tour);
        public void Edit(int TourId, string Description, int Price);
        public Tour FindTour(int id);
        public ICollection<Tour> GetAll();
        public Image GetImage(int id);
        public ICollection<Image> GetImages(int id);
        public void IncRating(int TourId);

        public ICollection<Tour> SearchManager(string Name);



    }


}
