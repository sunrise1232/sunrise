using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sunrise2._0.Data;
using Sunrise2._0.Storage.Entity;

namespace Sunrise2._0.Manager.ProvidersManager
{
    public class ProvidersManager:IProvidersManager
    {
        private SunriseContext _ContextProviders;




        public ProvidersManager(SunriseContext context)
        {
            _ContextProviders = context;
        }


        public ICollection<Provider> GetAll() => _ContextProviders.Providers.ToList();
    }
}
