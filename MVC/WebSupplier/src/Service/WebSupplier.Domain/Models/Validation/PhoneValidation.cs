using FluentValidation;
using WebSupplier.Domain.Models;

namespace WebSupplier.Domain.Models.Validation
{
    public class PhoneValidation : AbstractValidator<Phone>
    {
        public PhoneValidation()
        {
            RuleFor(x => x.Ddd)
                .Length(2, 2)
                .WithMessage("The DDD must contain 2 characters.");
                                               
            RuleFor(x => x.Number)
                .Length(8, 9)
                .WithMessage("Telephone must contain between 8 and 9 characters.");
            
        }
    }
}
