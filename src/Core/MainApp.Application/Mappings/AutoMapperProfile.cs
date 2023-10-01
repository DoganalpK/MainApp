using AutoMapper;
using MainApp.Application.Dtos.Product;
using MainApp.Domain.Entities;

namespace MainApp.Application.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Product, ProductCreateDto>().ReverseMap();
            CreateMap<Product, ProductListDto>().ReverseMap();
        }
    }
}
