using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab5_6.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Identity;
using Lab5_6.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab5_6
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
            services.AddSingleton<IUserProvider>(new UserProvider());
            services.AddSingleton<IPostProvider>(new PostProvider());

            services.AddDbContext<IdentityContext>(options =>
                //options.UseSqlite(Configuration["ConnectionStrings:DefaultConnection"]));
                options.UseSqlite("Data Source=Database.db"));

            //services.AddIdentityCore<User>()
            //    .AddRoles<IdentityRole<int>>()
            //    .AddEntityFrameworkStores<AppDbContext>()
            //    .AddSignInManager();
            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<IdentityContext>();

            //services.AddAuthentication(options =>
            //{
            //    options.DefaultScheme = IdentityConstants.ApplicationScheme;
            //})
            //.AddIdentityCookies(o => { });

            //services.AddControllersWithViews();
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "blog",
                    pattern: "blog/{id?}",
                    defaults: new { controller = "Feed", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
