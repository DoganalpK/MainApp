using AutoMapper;
using MainApp.Application.Dtos;
using MainApp.Application.Interfaces.Repositories;
using MediatR;

namespace MainApp.Application.Features.Queries.GetAllProducts
{
    public record GetAllProductsQuery(string a) : IRequest<List<ProductDto>>;

    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<ProductDto>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetAllProductsQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductDto>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetAllAsync();
            return _mapper.Map<List<ProductDto>>(products);
        }
    }
}
