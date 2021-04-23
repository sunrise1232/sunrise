using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sunrise2._0.Data;
using Sunrise2._0.Storage.Entity;

namespace Sunrise2._0.Manager.RegionManager
{
    public class RegionManagers:IRegionManager
    {

        private SunriseContext _ContextRegion;


        public RegionManagers(SunriseContext context)
        {
            _ContextRegion = context;
        }
        public ICollection<Region> GetAll() => _ContextRegion.Regions.ToList();

        public ICollection<Region> Index()
        {
            return _ContextRegion.Regions.ToList();
        }
    }
}
