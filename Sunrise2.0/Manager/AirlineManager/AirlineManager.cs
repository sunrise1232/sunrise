using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sunrise2._0.Storage.Entity;
using Sunrise2._0.Storage;
using Sunrise2._0.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Sunrise2._0.Manager.AirlineManger
{
    public class AirlineManager : IAirlineManager
    {

        private SunriseContext _ContextOrder;



        public AirlineManager(SunriseContext context)
        {
            _ContextOrder = context;
        }


        public async Task<ICollection<Airline>> GetAll()
        {
            return await _ContextOrder.Airlines.ToListAsync();
        }

    }
}
