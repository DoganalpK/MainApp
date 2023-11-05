using FluentValidation;
using MainApp.Application.Behaviours;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace MainApp.Application.DependencyResolvers
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            //var assm = Assembly.GetExecutingAssembly();
            //services.AddAutoMapper(assm);
            //services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()))
            //    .AddScoped(typeof(IPipelineBehavior<,>), typeof(IValidationBehaviour<,>));


            var assm = Assembly.GetExecutingAssembly();
            services.AddValidatorsFromAssembly(assm);
            services.AddAutoMapper(assm);
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()))
                .AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
        }
    }
}
