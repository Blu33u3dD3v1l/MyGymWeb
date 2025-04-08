using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using MyGymWeb.Data.Models;
using System.Reflection;


namespace MyGymWeb.WebExtensions
{
    public static class WebApplicationBuilderServices
    {
        public static void AddApplicationServices(this IServiceCollection services, System.Type ServiceType)
        {
            Assembly? serviceAssembly = Assembly.GetAssembly(ServiceType);
            if (serviceAssembly == null)
            {
                throw new InvalidOperationException("Invalid service type provided!");
            }

            System.Type[] serviceTypes = serviceAssembly.GetTypes()
                .Where(t => t.Name.EndsWith("Service") && !t.IsInterface)
                .ToArray();

            foreach (System.Type implementationType in serviceTypes)
            {
                System.Type? interfaceType = implementationType
                    .GetInterface($"I{implementationType.Name}");

                if (interfaceType == null)
                {
                    throw new InvalidOperationException($"No Interface is provided for the service with name: {implementationType.Name}");
                }

                services.AddScoped(interfaceType, implementationType);

            }

        }
        public static async Task<IApplicationBuilder> SeedAdministrator(this IApplicationBuilder app, string email)
        {

            using IServiceScope scopreServies = app.ApplicationServices.CreateScope();

            IServiceProvider serviceProvider = scopreServies.ServiceProvider;

            UserManager<ApplicationUser> userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            RoleManager<IdentityRole> roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();



            if (!await roleManager.RoleExistsAsync(AdminConstants.AdminRolleName))
            {
                IdentityRole role = new IdentityRole(AdminConstants.AdminRolleName);
                await roleManager.CreateAsync(role);

                ApplicationUser adminUser = await userManager.FindByEmailAsync(email);
                if (adminUser != null)
                {
                    await userManager.AddToRoleAsync(adminUser, AdminConstants.AdminRolleName);
                }
            }


            return app;
        }
    }

  
}
