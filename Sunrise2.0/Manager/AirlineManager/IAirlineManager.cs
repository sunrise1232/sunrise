﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sunrise2._0.Storage.Entity;

namespace Sunrise2._0.Manager.AirlineManger
{
    public interface IAirlineManager
    {

        public ICollection<Airline> GetAll();

    }
}
