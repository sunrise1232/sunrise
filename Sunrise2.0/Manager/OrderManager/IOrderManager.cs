﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sunrise2._0.Storage.Entity;

namespace Sunrise2._0.Manager.OrderManager
{
    public interface IOrderManager
    {

        public void add(Order purch);
        public ICollection<Order> GetAll();

        public ICollection<Order> Index();
    }
}
