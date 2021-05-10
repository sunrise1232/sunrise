using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sunrise2._0.Data;
using Sunrise2._0.Storage.Entity;

namespace Sunrise2._0.Manager.HotelManager
{
    public class HotelManager:IHotelManager
    {

        private SunriseContext _ContextHotel;


        public void Add(string Name, int TownId)
        {
            Hotel Hotel = new Hotel();
            Hotel.Name = Name;
            Hotel.TownId = TownId;
            _ContextHotel.Add(Hotel);
            _ContextHotel.SaveChanges();
        }

        public HotelManager(SunriseContext context)
        {
            _ContextHotel = context;
        }


        public ICollection<Hotel> GetAll() => _ContextHotel.Hotels.ToList();

        public int FindHotel(string Name, int townid)
        {



            var r = _ContextHotel.Hotels.Where(e => e.TownId == townid).First(d => d.Name == Name);


            return r.Id;
        }

        public ICollection<Hotel> Index11()
        {
            return _ContextHotel.Hotels.ToList();
        }
    }
}
