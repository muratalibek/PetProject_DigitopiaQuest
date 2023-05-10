using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitopiaQuest.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using DigitopiaQuest.Areas.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using DigitopiaQuest.Core;

namespace DigitopiaQuest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<UserManager<DigitopiaQuestUser>>();

            // Add services to the container.
            builder.Services.AddDbContext<DigitopiaQuestContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDbContext<DataContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<DigitopiaQuestUser>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddRoles<IdentityRole>() //for roles adding
                .AddEntityFrameworkStores<DigitopiaQuestContext>();
            //builder.Services.AddScoped<UserManager<DigitopiaQuestUser>>();

            builder.Services.AddControllersWithViews();
            builder.Services.AddRazorPages();

            #region Authorization

            AddAuthorizationPolicies(builder.Services);

            #endregion

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
 
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();

            void AddAuthorizationPolicies(IServiceCollection services)
            {
                services.AddAuthorization(options =>
                {
                    options.AddPolicy(Constants.Roles.Administrator, policy => policy.RequireRole(Constants.Roles.Administrator));
                    options.AddPolicy(Constants.Roles.Manager, policy => policy.RequireRole(Constants.Roles.Manager));
                    //options.AddPolicy("RequireUserRole", policy => policy.RequireRole("User", "Manager", "Administrator"));
                });
            }   
        }
    }
}
