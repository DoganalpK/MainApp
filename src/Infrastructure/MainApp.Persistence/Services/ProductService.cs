using AutoMapper;
using FluentValidation;
using MainApp.Application.Dtos.Product;
using MainApp.Application.Interfaces.Services;
using MainApp.Application.Interfaces.Uow;
using MainApp.Application.Services;
using MainApp.Domain.Entities;

namespace MainApp.Persistence.Services
{
    public class ProductService : Service<ProductCreateDto, ProductUpdateDto, ProductListDto, Product>, IProductService
    {
        //public ProductService(IUnitOfWork uow,
        //    IValidator<ProductCreateDto> createDtoValidator,
        //    IValidator<ProductUpdateDto> updateDtoValidator,
        //    IMapper mapper)
        //    : base(uow, createDtoValidator, updateDtoValidator, mapper)
        //{

        //}

        public ProductService(IUnitOfWork uow,
            IMapper mapper)
            : base(uow, mapper)
        {

        }
    }
}
