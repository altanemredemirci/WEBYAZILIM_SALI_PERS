using _07_Fluent_Validation.Models;
using FluentValidation;

namespace _07_Fluent_Validation.Validators
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Name).NotNull().WithMessage("Ürün ado boş geçilemez");

        }
    }
}
