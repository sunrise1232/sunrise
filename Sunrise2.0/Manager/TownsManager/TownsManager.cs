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




        public TownsManager(SunriseContext context)
        {
            _ContextTowns = context;
        }


        public ICollection<Town> GetAll() => _ContextTowns.Towns.ToList();
    }
}
