using FluentValidation;
using MainApp.Application.Dtos.Product;
using MainApp.Application.Features.Commands.CreateProduct;

namespace MainApp.Application.ValidationRules.FluentValidation
{
    public class ProductCreateDtoValidator : AbstractValidator<CreateProductCommand>
    {
        public ProductCreateDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
        }
    }
}
