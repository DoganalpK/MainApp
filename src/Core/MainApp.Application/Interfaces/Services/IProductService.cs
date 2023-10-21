using MainApp.Application.Interfaces.Repositories;
using MainApp.Domain.Entities;

namespace MainApp.Application.Interfaces.Services
{
    public interface IProductService : IRepository<Product>
    {
    }
}
