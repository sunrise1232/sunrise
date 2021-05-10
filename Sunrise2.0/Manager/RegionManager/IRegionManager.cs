using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sunrise2._0.Storage.Entity;

namespace Sunrise2._0.Manager.RegionManager
{
    public interface IRegionManager
    {

        public void Add(string Name);

        public int FindRegion(string Name);

        public ICollection<Region> GetAll();

        public ICollection<Region> Index();
    }
}
