using FluentValidation;
using MainApp.Application.Dtos.Product;

namespace MainApp.Persistence.ValidationRules.FluentValidation
{
    public class ProductCreateDtoValidator : AbstractValidator<ProductCreateDto>
    {
        public ProductCreateDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
        }
    }
}
