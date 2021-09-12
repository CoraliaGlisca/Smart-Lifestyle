using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SmartLifestyle.BusinessLogic.Services;
using SmartLifestyle.Models.Model;
using SmartLifestyle.Repository.Abstractions;
using SmartLifestyle.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLifestyle
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

            string connectionString = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<SmartLDbContext>(c => c.UseSqlServer(connectionString));

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddDefaultTokenProviders()
                .AddDefaultUI()
                .AddEntityFrameworkStores<SmartLDbContext>();
            services.AddTransient<IMealPlannerRepository, MealPlannerRepository>();
            services.AddTransient<MealPlannerService>();
            services.AddTransient<IWorkoutPlannerRepository, WorkoutPlannerRepository>();
            services.AddTransient<WorkoutPlannerService>();
            services.AddTransient<IWeekRepository       , WeekRepository>();
            services.AddTransient<IMondayRepository     , MondayRepository>();
            services.AddTransient<ITuesdayRepository    , TuesdayRepository>();
            services.AddTransient<IWednesdayRepository  , WednesdayRepository>();
            services.AddTransient<IThursdayRepository   , ThursdayRepository>();
            services.AddTransient<IFridayRepository     , FridayRepository>();
            services.AddTransient<ISaturdayRepository   , SaturdayRepository>();
            services.AddTransient<ISundayRepository     , SundayRepository>();
            services.AddTransient<IMealRepository       , MealRepository>();
            services.AddTransient<INutrientsRepository  , NutrientsRepository>();
            services.AddTransient<IUserOffsetRepository , UserOffsetRepository>();
            services.AddTransient<IFavoriteMealRepostiory, FavoriteMealRepository>();
            services.AddTransient<IFavoriteWorkoutRepository, FavoriteWorkoutRepository>();
            services.AddTransient<IWorkoutPlanRepository, WorkoutPlanRepository>();
            services.AddTransient<IWorkoutRepository, WorkoutRepository>();
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

            app.UseAuthentication();
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
