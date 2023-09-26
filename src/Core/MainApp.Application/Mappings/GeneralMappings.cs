using AutoMapper;
using MainApp.Application.Dtos;
using MainApp.Application.Features.Commands.CreateProduct;
using MainApp.Domain.Entities;

namespace MainApp.Application.Mappings
{
    public class GeneralMappings : Profile
    {
        public GeneralMappings()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Product, CreateProductCommand>().ReverseMap();
        }
    }
}
