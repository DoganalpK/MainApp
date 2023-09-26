using MainApp.Application.Interfaces.Contexts;
using MainApp.Application.Interfaces.Repositories;
using MainApp.Persistence.Contexts;
using MainApp.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MainApp.Persistence
{
    public static partial class ServiceRegistration
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


            services.AddTransient<IProductRepository, ProductRepository>();
        }
    }
}
