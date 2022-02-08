using FluentValidation;
using System;

namespace WebSupplier.Domain.Models.Validation
{
    public class CategoryValidation : AbstractValidator<Category>
    {
        public CategoryValidation()
        {
            RuleFor(x => x.Id)
                .NotEqual(Guid.Empty)
                .WithMessage("Invalid Id");

            RuleFor(x => x.Name)
                .Length(2, 100)
                .WithMessage("The Name must be counted between 2 and 256 characters.");
        }
    }
}
