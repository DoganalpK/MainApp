using FluentValidation;
using MainApp.Application.Dtos.Product;
using MainApp.Application.Interfaces.Contexts;
using MainApp.Application.Interfaces.Services;
using MainApp.Application.Interfaces.Uow;
using MainApp.Persistence.Contexts;
using MainApp.Persistence.Services;
using MainApp.Persistence.Uow;
using MainApp.Persistence.ValidationRules.FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MainApp.Persistence.DependencyResolvers
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<MainAppDbContext>(opt =>
            {
                opt.UseSqlServer(
                    "server=localhost; database=MainAppDb; integrated security=true;TrustServerCertificate=True;",
                    b => b.MigrationsAssembly(typeof(MainAppDbContext).Assembly.FullName));
            });



            services.AddScoped<IMainAppDbContext>(provider => provider.GetService<MainAppDbContext>());
            services.AddScoped<IUnitOfWork, UnitOfWork>();



            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IValidator<ProductCreateDto>, ProductCreateDtoValidator>();
        }
    }
}
