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




        public HotelManager(SunriseContext context)
        {
            _ContextHotel = context;
        }


        public ICollection<Hotel> GetAll() => _ContextHotel.Hotels.ToList();
       

        public ICollection<Hotel> Index11()
        {
            return _ContextHotel.Hotels.ToList();
        }
    }
}
