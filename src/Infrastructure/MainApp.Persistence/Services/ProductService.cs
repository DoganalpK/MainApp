using MainApp.Application.Interfaces.Services;
using MainApp.Domain.Entities;
using MainApp.Persistence.Contexts;
using MainApp.Persistence.Repositories;

namespace MainApp.Persistence.Services
{
    public class ProductService : Repository<Product>, IProductService
    {
        public ProductService(MainAppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
