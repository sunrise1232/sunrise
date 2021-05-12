using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sunrise2._0.Data;
using Sunrise2._0.Storage.Entity;
using Microsoft.EntityFrameworkCore;

namespace Sunrise2._0.Manager.TownsManager
{
    public class TownsManager:ITownsManager
    {
        private SunriseContext _ContextTowns;


        public async Task Add(string Name, int RegionId)
        {
            Town Town= new Town();
            Town.Name = Name;
            Town.RegionId = RegionId;
            await _ContextTowns.AddAsync(Town);
            await _ContextTowns.SaveChangesAsync();
        }

        public int FindTowns(string Name,int regionid)
        {

           

            var r = _ContextTowns.Towns.Where(e=> e.RegionId== regionid).First(d => d.Name == Name);


            return r.Id;
        }
        public TownsManager(SunriseContext context)
        {
            _ContextTowns = context;
        }


        public async Task<ICollection<Town>> GetAll() => await _ContextTowns.Towns.ToListAsync();
    }
}
