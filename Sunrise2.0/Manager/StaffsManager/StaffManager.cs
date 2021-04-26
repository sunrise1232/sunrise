using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sunrise2._0.Data;
using Sunrise2._0.Storage.Entity;

namespace Sunrise2._0.Manager.StaffsManager
{
    public class StaffManager:IStaffsManageres
    {
        private SunriseContext _ContextStaffs;




        public StaffManager(SunriseContext context)
        {
            _ContextStaffs = context;
        }


        public ICollection<Staff> GetAll() => _ContextStaffs.Staffs.ToList();
    }
}
