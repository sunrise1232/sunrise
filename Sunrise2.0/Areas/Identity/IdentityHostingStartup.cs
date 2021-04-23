using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sunrise2._0.Areas.Identity.Data;
using Sunrise2._0.Data;

[assembly: HostingStartup(typeof(Sunrise2._0.Areas.Identity.IdentityHostingStartup))]
namespace Sunrise2._0.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<SunriseContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("SunriseContextConnection")));

                services.AddDefaultIdentity<Client>(options => {
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                    options.SignIn.RequireConfirmedAccount = false;
                })
                    .AddEntityFrameworkStores<SunriseContext>();
            });
        }
    }
}