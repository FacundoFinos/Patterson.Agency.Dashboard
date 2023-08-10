using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Patterson.Agency.Dashboard.Application
{
    public static class DependencyInjection
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            services.AddMediatR(cfg => 
                cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        }
    }
}
