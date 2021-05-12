using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sunrise2._0.Storage.Entity;
using Sunrise2._0.Storage;
using Sunrise2._0.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Sunrise2._0.Manager.OrderManager
{
    public class OrderManager : IOrderManager
    {

        private SunriseContext _ContextOrder;

      

        public OrderManager(SunriseContext context)
        {
            _ContextOrder = context;
        }

        public async Task Add(Order purch)
        {
            purch.Date = DateTime.Now;
           await _ContextOrder.Orders.AddAsync(purch);
           await _ContextOrder.SaveChangesAsync();
        }

        public async Task<ICollection<Order>> GetAll()
        {
            return await _ContextOrder.Orders.Include(o => o.Tour.Hotel.Town.Region).Include(o => o.Client).Include(o => o.Airline).ToListAsync();
        }

    }
}
