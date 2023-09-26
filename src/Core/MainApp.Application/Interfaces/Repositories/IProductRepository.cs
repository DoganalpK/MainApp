using MainApp.Domain.Entities;

namespace MainApp.Application.Interfaces.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        void OnlyAddProduct(Product product);
    }
}
