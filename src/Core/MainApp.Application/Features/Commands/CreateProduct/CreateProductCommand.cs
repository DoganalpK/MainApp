using AutoMapper;
using MainApp.Application.Interfaces.Repositories;
using MediatR;

namespace MainApp.Application.Features.Commands.CreateProduct
{
    public class CreateProductCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Value { get; set; }

        public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
        {
            private readonly IProductRepository _productRepository;
            private readonly IMapper _mapper;

            public CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
            {
                _productRepository = productRepository;
                _mapper = mapper;
            }

            public async Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
            {
                var product = _mapper.Map<Domain.Entities.Product>(request);
                await _productRepository.CreateAsync(product);
                return product.Id;
            }
        }
    }
}
