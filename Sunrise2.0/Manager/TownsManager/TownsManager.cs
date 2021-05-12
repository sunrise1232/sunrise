using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sunrise2._0.Data;
using Sunrise2._0.Storage.Entity;

namespace Sunrise2._0.Manager.TownsManager
{
    public class TownsManager:ITownsManager
    {
        private SunriseContext _ContextTowns;


        public void Add(string Name, int RegionId)
        {
            Town Town= new Town();
            Town.Name = Name;
            Town.RegionId = RegionId;
            _ContextTowns.Add(Town);
            _ContextTowns.SaveChanges();
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


        public ICollection<Town> GetAll() => _ContextTowns.Towns.ToList();
    }
}
