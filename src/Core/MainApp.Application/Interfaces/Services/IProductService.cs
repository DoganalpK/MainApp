using MainApp.Application.Dtos.Product;
using MainApp.Domain.Entities;

namespace MainApp.Application.Interfaces.Services
{
    public interface IProductService : IService<ProductCreateDto, ProductUpdateDto, ProductListDto, Product>
    {
    }
}
