using FluentValidation;
using MainApp.Application.Dtos.Product;

namespace MainApp.Persistence.ValidationRules.FluentValidation
{
    public class ProductListDtoValidator : AbstractValidator<ProductListDto>
    {
        public ProductListDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
        }
    }
}
