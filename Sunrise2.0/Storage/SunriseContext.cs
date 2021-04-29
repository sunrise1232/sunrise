using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sunrise2._0.Areas.Identity.Data;
using Sunrise2._0.Storage.Entity;

namespace Sunrise2._0.Data
{
    public class SunriseContext : IdentityDbContext<Client>
    {
        public SunriseContext(DbContextOptions<SunriseContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<Region> Regions { get; internal set; }
        public DbSet<Flight> Flights { get; internal set; }
        public DbSet<Airline> Airlines { get; internal set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
