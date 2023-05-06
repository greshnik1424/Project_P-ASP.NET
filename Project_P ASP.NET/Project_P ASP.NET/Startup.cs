using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Project_P_ASP.NET.Data;
using Project_P_ASP.NET.Data.Interfaces;
using Project_P_ASP.NET.Data.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project_P_ASP.NET.Data.Repository;
using Project_P_ASP.NET.Data.Models;

namespace Project_P_ASP.NET
{
    public class Startup
    {

        private IConfigurationRoot _confString;

        public Startup(Microsoft.AspNetCore.Hosting.IHostingEnvironment hostEnv)
        {
            //отримання файлу зі строкою підключення БД
            _confString = new ConfigurationBuilder().SetBasePath(hostEnv.
            ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }
        
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(
            _confString.GetConnectionString("DefaultConnection"))); services.AddTransient<IAllFlowers, MockFlowers>();
            services.AddTransient<IAllFlowers, FlowerRepository>();
            services.AddTransient<IFlowersCategory, CategoryRepository>();
            services.AddTransient<IAllOrders, OrdersRepository>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => Cart.GetCart(sp));
            services.AddMvc(MvcOptions=> {
                MvcOptions.EnableEndpointRouting = false;
            });
            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //відображення помилок
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();//відображення коду сторінки8
            app.UseStaticFiles();//для відображення різних файлів, таких
                                 //як зображення, css-файли та інше
            app.UseSession();
            app.UseMvcWithDefaultRoute();//для маршрутизації за замовчування
            //прописуємо власну маршрутизацію та url-адреси
            app.UseMvc(routes => {
                routes.MapRoute(name: "default", template: "{controller-Home}/{action-Index}/{id?}");
                routes.MapRoute(name: "categoryFilter", template:
                "Flowers/{action}/{category?}", defaults: new
                {
                    Controller = "Flowers",
                    action = "List"
                });
            });
            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
                DBObjects.Initial(content);
            }
        }
    }
}