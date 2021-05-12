﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sunrise2._0.Storage.Entity;


namespace Sunrise2._0.Manager.HotelManager
{
    public interface IHotelManager
    {
        public Task Add(string Name, int TownId);
        public int FindHotel(string Name, int TownId);

        public Task<ICollection<Hotel>> GetAll();

        public Task<ICollection<Hotel>> Index11();
    }
}
