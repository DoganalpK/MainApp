using AutoMapper;
using MainApp.Application.Dtos.Product;
using MainApp.Application.Interfaces.Services;
using MainApp.Application.Interfaces.Uow;
using MainApp.Application.Wrappers;
using MainApp.Domain.Entities;
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

        public GetAllProductsQueryHandler(IUnitOfWork unitOfWork, IProductService productService, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _productService = productService;
            _mapper = mapper;
        }

        public async Task<IResponse<List<ProductListDto>>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var aa = await _unitOfWork.GetRepository<Product>().GetAllAsync();


            throw new NotImplementedException();
        }
    }
}
