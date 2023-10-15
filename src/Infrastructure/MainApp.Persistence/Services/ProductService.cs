using AutoMapper;
using MainApp.Application.Dtos.Product;
using MainApp.Application.Interfaces.Services;
using MainApp.Application.Interfaces.Uow;
using MainApp.Application.Services;
using MainApp.Domain.Entities;

namespace MainApp.Persistence.Services
{
    public class ProductService : Service<ProductCreateDto, ProductUpdateDto, ProductListDto, Product>, IProductService
    {
        public ProductService(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
        {
        }
    }
}
