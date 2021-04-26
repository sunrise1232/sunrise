using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sunrise2._0.Storage.Entity;

namespace Sunrise2._0.Manager.FlightManager
{
    public interface IFlightManager
    {
        public ICollection<Flight> GetAll();
    }
}
