using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sunrise2._0.Data;
using Sunrise2._0.Storage.Entity;
using Microsoft.EntityFrameworkCore;

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


        public async Task<ICollection<Hotel>> GetAll() => await _ContextHotel.Hotels.ToListAsync();

        public int FindHotel(string Name, int townid)
        {



            var r = _ContextHotel.Hotels.Where(e => e.TownId == townid).First(d => d.Name == Name);


            return r.Id;
        }

        public async Task<ICollection<Hotel>> Index11()
        {
            return await _ContextHotel.Hotels.ToListAsync();
        }
    }
}
