using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sunrise2._0.Storage.Entity;
using Sunrise2._0.Storage;
using Sunrise2._0.Data;

namespace Sunrise2._0.Manager.OrderManager
{
    public class OrderManager : IOrderManager
    {

        private SunriseContext _ContextOrder;

      

        public OrderManager(SunriseContext context)
        {
            _ContextOrder = context;
        }

        public void add(Order purch)
        {
            purch.Date = DateTime.Now;
            _ContextOrder.Orders.Add(purch);
            _ContextOrder.SaveChanges();
        }

        public ICollection<Order> GetAll()
        {
            return _ContextOrder.Orders.ToList();
        }

        public ICollection<Order> Index()
        {
            return _ContextOrder.Orders.ToList();
        }
    }
}
