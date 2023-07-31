namespace MyGymWeb.Web.Extensions.Extensions
{
    using Microsoft.Extensions.DependencyInjection;
    using MyGymWeb.Services;
    using MyGymWeb.Services.Interface;
    using System;
    using System.Reflection;

    public static class WevApplicationBuilderServices
    {
        public static void AddApplicationServices(this IServiceCollection services, Type ServiceType)
        {
            Assembly? serviceAssembly = Assembly.GetAssembly(ServiceType);
            if (serviceAssembly == null)
            {
                throw new InvalidOperationException("Invalid service type provided!");
            }

            Type[] serviceTypes = serviceAssembly.GetTypes()
                .Where(t => t.Name.EndsWith("Service") && !t.IsInterface)
                .ToArray();

            foreach (Type implementationType in serviceTypes)
            {
                Type? interfaceType = implementationType
                    .GetInterface($"I{implementationType.Name}");

                if (interfaceType == null)
                {
                    throw new InvalidOperationException($"No Interface is provided for the service with name: {implementationType.Name}");
                }

                services.AddScoped(interfaceType, implementationType);

            }

        }
    }
}
