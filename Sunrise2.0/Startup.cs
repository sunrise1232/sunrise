using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Sunrise2._0.Manager.AirlineManger;
using Sunrise2._0.Manager.HotelManager;
using Sunrise2._0.Manager.OrderManager;
using Sunrise2._0.Manager.RegionManager;
using Sunrise2._0.Manager.TourManager;
using Sunrise2._0.Manager.TownsManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    // static int operator+(Peron Person1, Person Person2) {
    
//}



namespace Sunrise2._0
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddRazorPages();

            services.AddTransient<ITourManager, TourManager>();
            services.AddTransient<IOrderManager, OrderManager>();
            services.AddTransient<IAirlineManager, AirlineManager>();
            services.AddTransient<IRegionManager, RegionManagers>();
            services.AddTransient<ITownsManager, TownsManager>();
            services.AddTransient<IHotelManager, HotelManager>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
