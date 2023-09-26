using MainApp.Application.Interfaces.Repositories;
using MainApp.Domain.Entities;
using MainApp.Persistence.Contexts;

namespace MainApp.Persistence.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(MainAppDbContext dbContext) : base(dbContext) { }

        public void OnlyAddProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
