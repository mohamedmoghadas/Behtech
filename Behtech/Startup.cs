using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Behtech
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddDbContext<BaseModel.BehTechEntities>(p =>
            {
                p.UseSqlServer("data source=.;initial catalog=BehTech;Integrated Security=true;");
            }, ServiceLifetime.Scoped);

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDefaultFiles();
            app.UseStaticFiles();
            //app.UseMvcWithDefaultRoute();
            
            ConfigRouting(app);
        }

        private static void ConfigRouting(IApplicationBuilder app)
        {




            app.UseMvc(route =>
            {

                route.MapAreaRoute("Default", "FCustomer", "{area}/{controller}/{action}/{id?}", new { area = "FCustomer", controller = "Home", action = "Index" });
            });


            app.UseMvc(route =>
            {
                route.MapRoute("Index", "LogOutCustomer", new { area = "FCustomer", controller = "RLCustomer", action = "LogOut" });

            });

            app.UseMvc(route =>
            {
                route.MapRoute("Index", "login_register", new { area = "FCustomer", controller = "RLCustomer", action = "Index" });

            });

            app.UseMvc(route =>
            {
                route.MapRoute("Index", "_HomeFCustomerarea", new { area = "FCustomerarea", controller = "Home", action = "Index" });

            });

            app.UseMvc(route =>
            {

                route.MapAreaRoute("Index", "FCustomerarea", "{area}/{controller}/{action}/{id?}", new { area = "FCustomerarea", controller = "Home", action = "Index" });
            });

            app.UseMvc(route =>
            {
                route.MapAreaRoute("AdminDefault", "Admin", "{area}/{controller}/{action}/{id?}", new { area = "Admin", controller = "Home", action = "Index" });


            });




        }
    }
}
