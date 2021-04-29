using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sunrise2._0.Storage.Entity;
using Sunrise2._0.Storage;
using Sunrise2._0.Data;
using Microsoft.AspNetCore.Identity;

namespace Sunrise2._0.Manager.OrderManager
{
    public class OrderManager : IOrderManager
    {

        private SunriseContext _ContextOrder;

      

        public OrderManager(SunriseContext context)
        {
            _ContextOrder = context;
        }

        public void Add(Order purch)
        {
            //var date1 = new DateTime(2020, 3, 3);
            IdentityUser User = new IdentityUser();


            //purch.ClientId = "5386dae7-129f-4293-a519-dd296533dabf";
            purch.Date = DateTime.Now;
            purch.TourId = 7;
            _ContextOrder.Orders.Add(purch);
            _ContextOrder.SaveChanges();
        }

        public ICollection<Order> GetAll()
        {
            return _ContextOrder.Orders.ToList();
        }

    }
}
