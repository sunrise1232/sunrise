using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sunrise2._0.Storage;
using Sunrise2._0.Storage.Entity;
using Microsoft.EntityFrameworkCore;
using Sunrise2._0.Data;
using Sunrise2._0.Areas.Identity.Data;

namespace Sunrise2._0.Managers.Clients
{
    public class ClientManager: IClientManager
    {
        private SunriseContext _ContextClient;

        /* public Client()
          {
              _ContextClient = new PeopleContext();
          }
        */

        public ClientManager(SunriseContext context)
        {
            _ContextClient = context;
        }

       
        public void AddClient(Client client)
        {
            _ContextClient.Clients.Add(client);
        }

        public ICollection<Client> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
