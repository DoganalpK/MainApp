using MainApp.Application.Dtos.Product;
using MainApp.Application.Interfaces.Uow;
using MainApp.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Application.Features.Commands.CreateProduct
{
    public class CreateProductCommand : IRequest<ProductCreateDto>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Value { get; set; }
    }

    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ProductCreateDto>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateProductCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ProductCreateDto> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            await _unitOfWork.GetRepository<Product>().CreateAsync(new Product());
            throw new NotImplementedException();
        }
    }
}
