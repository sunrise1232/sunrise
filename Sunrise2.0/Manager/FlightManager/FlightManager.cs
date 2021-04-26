using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sunrise2._0.Data;
using Sunrise2._0.Storage.Entity;

namespace Sunrise2._0.Manager.FlightManager
{
    public class FlightManager
    {

        private SunriseContext _ContextFlight;




        public FlightManager(SunriseContext context)
        {
            _ContextFlight = context;
        }


        public ICollection<Flight> GetAll() => _ContextFlight.Flights.ToList();
    }
}
