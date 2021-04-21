using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sunrise2._0.Storage.Entity;
using Sunrise2._0.Storage;
using Sunrise2._0.Areas.Identity.Data;

namespace Sunrise2._0.Managers.Clients
{
    interface IClientManager
    {
        ICollection<Client> GetAll();

        void AddClient(Client Client);
        //void AuthorizationClient(string login, string password);
    }
}
