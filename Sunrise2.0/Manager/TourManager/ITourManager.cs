﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sunrise2._0.Storage.Entity;

namespace Sunrise2._0.Manager.TourManager
{
    public interface ITourManager
    {
        public ICollection<Tour> GetAll();

        public ICollection<Tour> Index11();
        public void addname(Tour tour);

    }
}
