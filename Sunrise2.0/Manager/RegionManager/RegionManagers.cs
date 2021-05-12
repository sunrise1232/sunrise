using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sunrise2._0.Data;
using Sunrise2._0.Storage.Entity;
using Microsoft.EntityFrameworkCore;

namespace Sunrise2._0.Manager.RegionManager
{
    public class RegionManagers:IRegionManager
    {

        private SunriseContext _ContextRegion;

        public async Task Add(string Name)
        {
            Region Region = new Region();
            Region.Name = Name;
            await _ContextRegion.AddAsync(Region);
            await _ContextRegion.SaveChangesAsync();
        }

        public int FindRegion(string Name)
        {
           
   

                var r = _ContextRegion.Regions.First(d => d.Name == Name);
               
      
            return r.Id;
        }
      
        public RegionManagers(SunriseContext context)
        {
            _ContextRegion = context;
        }

        public async Task<ICollection<Region>> GetAll() => (ICollection<Region>)await _ContextRegion.Regions.ToListAsync();

      

        public async Task<ICollection<Region>> Index()
        {
            return (ICollection<Region>)await _ContextRegion.Regions.ToListAsync();
        }
    }
}
