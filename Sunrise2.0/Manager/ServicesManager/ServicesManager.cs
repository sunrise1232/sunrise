using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sunrise2._0.Data;
using Sunrise2._0.Storage.Entity;

namespace Sunrise2._0.Manager.ServicesManager
{
    public class ServicesManager:IServicesManager
    {
        private SunriseContext _ContextServices;




        public ServicesManager(SunriseContext context)
        {
            _ContextServices = context;
        }


        public ICollection<Service> GetAll() => _ContextServices.Services.ToList();
    }
}
