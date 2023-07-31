using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyGymWeb.Data;
using MyGymWeb.Data.Models;
using MyGymWeb.Services.Interface;
using MyGymWeb.Web.Extensions.Extensions;
using MyGymWeb.WebExtensions;

namespace MyGymWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<MyGymProjectDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
            {

                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireUppercase = true;
                options.Password.RequireDigit = true;


            }).AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<MyGymProjectDbContext>();

            builder.Services.AddControllersWithViews(options =>
            {
                options.Filters.Add<AutoValidateAntiforgeryTokenAttribute>();
            });

            builder.Services.AddApplicationServices(typeof(ITrainerService));
            //builder.Services.AddResponseCaching();

            //builder.Services.AddScoped<IGymService, GymService>();
            //builder.Services.AddScoped<ITrainerService, TrainerService>();
            //builder.Services.AddScoped<IProductService, ProductService>();
            //builder.Services.AddScoped<IUserService, UserService>();
            //builder.Services.AddScoped<IApplyService, ApplyService>();
            //builder.Services.AddScoped<IAppointmentService, AppointmentService>();

            builder.Services.ConfigureApplicationCookie(cfg =>
            {
                cfg.LoginPath = "/User/Login";
            });

            var app = builder.Build();




            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.SeedAdministrator(AdminConstants.AdminEmail);
            app.UseEndpoints(endpoints =>
            {



                app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                name: "areas",
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                app.MapControllerRoute(
                name: "trainerDetails",
                pattern: "Trainer/Details/{information}");


                endpoints.MapRazorPages();

            });

            app.UseResponseCaching();
            app.Run();
        }
    }
}