using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace MainApp.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            var assm = Assembly.GetExecutingAssembly();

            services.AddAutoMapper(assm);
            //services.AddMediatR(assm);
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
        }
    }
}
