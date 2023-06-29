using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MyGymWeb.Data;
using MyGymWeb.Services;
using MyGymWeb.Services.Interface;

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

            builder.Services.AddDefaultIdentity<IdentityUser>(options =>
            {

                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireUppercase = true;
                options.Password.RequireDigit = true;

            }).AddEntityFrameworkStores<MyGymProjectDbContext>();
            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<IGymService, GymService>();
            builder.Services.AddScoped<ITrainerService, TrainerService>();
            builder.Services.AddScoped<IProductService, ProductService>();

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

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
    }
}