namespace MyGymWeb.Web.Extensions.Extensions
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.DependencyInjection;
    using MyGymWeb.Data.Models;
    using System;
    using System.Reflection;
    
    
    
 /// <summary>
 /// 
 /// </summary>
    public static class WevApplicationBuilderServices
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
        public static IApplicationBuilder SeedAdministrator(this IApplicationBuilder app, string email)
        {


            
            using IServiceScope scopreServies = app.ApplicationServices.CreateScope();

            IServiceProvider serviceProvider = scopreServies.ServiceProvider;

            UserManager<ApplicationUser> userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            RoleManager<IdentityRole> roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();


            Task.Run(async () =>
            {
                if (await roleManager.RoleExistsAsync(AdminConstants.AdminRolleName))
                {
                    return;
                }

                IdentityRole role = new IdentityRole(AdminConstants.AdminRolleName);

                await roleManager.CreateAsync(role);

                ApplicationUser adminUser = await userManager.FindByEmailAsync(email);
                

                await userManager.AddToRoleAsync(adminUser, AdminConstants.AdminRolleName);

                

            })
             .GetAwaiter()
             .GetResult();

            return app;
        }
    }

  
}
