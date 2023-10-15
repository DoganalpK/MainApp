using AutoMapper;
using MainApp.Application.Dtos.Product;
using MainApp.Application.Interfaces.Services;
using MainApp.Application.Interfaces.Uow;
using MainApp.Application.Wrappers;
using MediatR;

namespace MainApp.Application.Features.Queries.GetAllProducts
{
    public class GetAllProductsQuery : IRequest<IResponse<List<ProductListDto>>>
    {
    }

    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IResponse<List<ProductListDto>>>
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public GetAllProductsQueryHandler(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        public async Task<IResponse<List<ProductListDto>>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var aa = await _productService.GetAllAsync();
            throw new NotImplementedException();
        }

        //public async Task<IResponse<List<ProductListDto>>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        //{
        //    var aa = await _productService.GetAllAsync();
        //    return aa;
        //}
    }
}
